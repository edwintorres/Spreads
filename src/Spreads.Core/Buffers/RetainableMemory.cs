﻿// This Source Code Form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this
// file, You can obtain one at http://mozilla.org/MPL/2.0/.

using Spreads.Native;
using Spreads.Threading;
using Spreads.Utils;
using System;
using System.Buffers;
using System.Runtime.CompilerServices;
using Spreads.Serialization;
using static Spreads.Buffers.BuffersThrowHelper;

namespace Spreads.Buffers
{
    internal static class RetainableMemoryTracker
    {
        internal static ConditionalWeakTable<object, string> Tags = new ConditionalWeakTable<object, string>();
    }

    internal class RetainableMemoryHelper
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref Vec GetVecRef(object pm)
        {
            // RM is generic only on array T[], which is a reference type
            // and could be stored as object and then casted via Unsafe.As.
            // So effectively the physical layout is identical for all Ts.
            // We also store T[] as object to be explicit and use Unsafe.As<T[]>(_array). 
            // TODO verify that it's safe, Benchmark access vs VecStorage in DB 
            return ref Unsafe.As<PrivateMemory<byte>>(pm).Vec;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T UnsafeGet<T>(object pm, IntPtr index)
        {
            // RM is generic only on array T[], which is a reference type
            // and could be stored as object and then casted via Unsafe.As.
            // So effectively the physical layout is identical for all Ts.
            // We also store T[] as object to be explicit and use Unsafe.As<T[]>(_array). 
            // TODO verify that it's safe, Benchmark access vs VecStorage in DB 
            return Unsafe.As<PrivateMemory<byte>>(pm).Vec.UnsafeGetUnaligned<T>(index);
        }
    }

    
    /// <summary>
    /// Base class for reference counted memory from a pool of arrays or from native memory.
    /// </summary>
    public abstract unsafe class RetainableMemory<T> : RefCountedMemory<T>
    {
        protected int _length;
        
        // [p*<-len---------------->] we must only check capacity at construction and then work from pointer
        // [p*<-len-[<--lenPow2-->]>] buffer could be larger, pooling always by max pow2 we could store
        protected IntPtr _pointer;
        
        // Even when unused it is a part of padding, which needed to avoid false sharing on _counter
        // Without this field we would need to make padding bigger in SharedMemory. Both PM and AM use it.
        internal object? _array;
        
        internal int _offset;
        
#pragma warning disable 649
        internal short Reserved;
#pragma warning restore 649

        /// <summary>
        /// 0 - externally owned;
        /// 1 - default array pool (no RM pool);
        /// 2+ - custom pool.
        /// </summary>
        internal byte PoolIndex;

        /// <summary>
        /// True if the memory is already clean (all zeros) on return. Useful for the case when
        /// the pool has <see cref="RetainableMemoryPool{T}.IsRentAlwaysClean"/> set to true
        /// but we know that the buffer is already clean. Use with caution only when cleanliness
        /// is obvious and when cost of cleaning could be high (larger buffers).
        /// </summary>
        [Obsolete("Don't use unless 100% sure.")] // Keep this hook for now, but if it's never used remove the field later. 
        internal bool SkipCleaning;

        internal Vec Vec;
        
        /// <summary>
        /// A pool sets this value atomically from inside a lock.
        /// </summary>
        internal bool IsPooled => IsDisposed && PoolIndex > 1;

        internal RetainableMemoryPool<T>? Pool
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => RetainableMemoryPool<T>.KnownPools[PoolIndex];
        }

        /// <summary>
        /// An array was allocated manually. Otherwise even if _pool == null we return the array to default array pool on Dispose.
        /// </summary>
        protected bool ExternallyOwned
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => PoolIndex == 0;
        }

        internal void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*) _pointer;
        }

        /// <summary>
        /// Extra space (if any) is at the beginning.
        /// </summary>
        internal void* PointerPow2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => Unsafe.Add<T>((void*) _pointer, _length - LengthPow2);
        }

        /// <summary>
        /// The underlying memory is a pinned array or native memory.
        /// </summary>
        public bool IsPinned
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => _pointer != IntPtr.Zero;
        }

        internal bool IsPoolable
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => PoolIndex > 1;
        }

        public int Length
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => _length;
        }

        /// <summary>
        /// Length for pool buckets. To simplify and speedup implementation we just
        /// use default pow2 pool logic without virtual methods and complexity of
        /// calculating lengths. A buffer is pooled by max pow2 it could fit into.
        /// </summary>
        internal int LengthPow2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => BitUtil.FindPreviousPositivePowerOfTwo(_length);
        }

        /// <summary>
        /// Returns <see cref="Vec{T}"/> backed by the memory of this instance.
        /// </summary>
        public abstract Vec<T> GetVec();

        internal DirectBuffer DirectBuffer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (IsPooled)
                {
                    ThrowDisposed<RetainableMemory<T>>();
                }

                ThrowHelper.DebugAssert(_pointer != null && _length > 0, "Pointer != null && _length > 0");

                return new DirectBuffer(_length * Unsafe.SizeOf<T>(), (byte*) _pointer);
            }
        }

        [Obsolete("Prefer fixed statements on a pinnable reference for short-lived pinning")]
#pragma warning disable CS0809 // Obsolete member overrides non-obsolete member
        public override MemoryHandle Pin(int elementIndex = 0)
#pragma warning restore CS0809 // Obsolete member overrides non-obsolete member
        {
            if (unchecked((uint) elementIndex) >= _length)
                ThrowIndexOutOfRange();

            if (TypeHelper<T>.IsReferenceOrContainsReferences)
            {
                ThrowNotPinnable();
            }
            else if (_pointer == IntPtr.Zero)
            {
                ThrowHelper.ThrowInvalidOperationException("RetainableMemory that is not backed by a pointer must have it's own implementation (override) of Pin method.");
            }

            Increment();
            return new MemoryHandle(Unsafe.Add<T>((void*) _pointer, elementIndex), handle: default, this);
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        protected static void ThrowNotPinnable()
        {
            ThrowHelper.ThrowInvalidOperationException($"Type {typeof(T).Name} is not pinnable.");
        }

        [Obsolete("Unpin should never be called directly, it is called during disposal of MemoryHandle returned by Pin.")]
#pragma warning disable CS0809 // Obsolete member overrides non-obsolete member
        public override void Unpin()
#pragma warning restore CS0809 // Obsolete member overrides non-obsolete member
        {
            Decrement();
        }

        /// <summary>
        /// Retain buffer memory.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RetainedMemory<T> Retain()
        {
            return Retain(0, _length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal RetainedMemory<T> RetainPow2()
        {
            var lengthPow2 = LengthPow2;
            return Retain(_length - lengthPow2, lengthPow2);
        }

        /// <summary>
        /// Retain buffer memory without pinning it.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RetainedMemory<T> Retain(int start, int length, bool borrow = true) // TODO remove borrow param, Retain == borrow
        {
            if ((uint) start + (uint) length > (uint) _length)
            {
                ThrowBadLength();
            }

            return new RetainedMemory<T>(this, start, length, borrow: borrow);
        }

        /// <summary>
        /// Clear remaining object fields during <see cref="RefCountedMemory{T}.Free"/> and before object pooling.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal virtual void ClearFields()
        {
            ThrowHelper.DebugAssert(AtomicCounter.GetIsDisposed(ref CounterRef));
            ThrowHelper.DebugAssert(!IsPooled);
            _pointer = IntPtr.Zero;
            _offset = -1; // make it unusable if not re-initialized
            _length = default; // not -1, we have uint cast. Also len = 0 should not corrupt existing data
            PoolIndex = default;
            Vec = default;
        }
        
        protected sealed override void Dispose(bool disposing)
        {
            // This overload if from MemoryManager<T> and is called from it's IDisposable
            // implementation, so we have to keep it. But MM doesn't have a finalizer 
            // and we call Free instead of Dispose(false) for destroying this object,
            // while Dispose(true) is for returning a memory object to a pool.
            if (!disposing)
                ThrowHelper.ThrowInvalidOperationException("Should not call PrivateMemory.Dispose(false)");

            var zeroIfDisposedNow = AtomicCounter.TryDispose(ref CounterRef);

            if (zeroIfDisposedNow > 0)
                ThrowDisposingRetained<PrivateMemory<T>>();

            if (zeroIfDisposedNow == -1)
                ThrowDisposed<PrivateMemory<T>>();

            var pool = Pool;
            if (pool != null && pool.ReturnInternal(this, clearMemory: TypeHelper<T>.IsReferenceOrContainsReferences))
                return;

            GC.SuppressFinalize(this);
            Free(finalizing: false);
        }
    }
}