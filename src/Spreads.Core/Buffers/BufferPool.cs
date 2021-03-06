﻿// This Source Code Form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this
// file, You can obtain one at http://mozilla.org/MPL/2.0/.

using System;
using System.Buffers;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Spreads.Buffers
{
    public static class BufferPool<T>
    {
        /// <summary>
        /// Retrieves an array that is at least the requested length.
        /// </summary>
        /// <param name="minLength"></param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T[] Rent(int minLength)
        {
            return ArrayPool<T>.Shared.Rent(minLength);
        }

        /// <summary>
        /// Return an array to the pool.
        /// </summary>
        /// <param name="array">An array to return.</param>
        /// <param name="clearArray">Force clear of arrays of blittable types. Arrays that could have references are always cleared.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Return(T[] array, bool clearArray = false)
        {
            ArrayPool<T>.Shared.Return(array, clearArray);
        }

        // This is entry/exit point for data buffers. All in-memory data containers use this pool.
        public static RetainableMemoryPool<T> MemoryPool = new RetainableMemoryPool<T>(
                factory: null,
                minLength: Settings.MIN_POOLED_BUFFER_LEN,
                maxLength: Math.Max(Settings.MIN_POOLED_BUFFER_LEN, Settings.LARGE_BUFFER_LIMIT / Unsafe.SizeOf<T>()),
                maxBuffersPerBucketPerCore: 16,
                maxBucketsToTry: 2);
    }

    public class BufferPool
    {
        private static readonly BufferPool Shared = new BufferPool();

        [Obsolete("Main RMP is already pinned for all blittables")]
        internal static RetainableMemoryPool<byte> PinnedArrayMemoryPool =
            new RetainableMemoryPool<byte>(
                factory: null,
                minLength: 2048,
                maxLength: 8 * 1024 * 1024,
                maxBuffersPerBucketPerCore: (4 + Environment.ProcessorCount) * 4,
                maxBucketsToTry: 2);

        internal BufferPool()
        { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private RetainedMemory<byte> RetainMemory(int length, bool requireExact = true, bool borrow = true)
        {
            var arrayMemory = PinnedArrayMemoryPool.RentMemory(length, requireExact);
            if (arrayMemory.IsDisposed)
            {
                BuffersThrowHelper.ThrowDisposed<ArrayMemory<byte>>();
            }
            return requireExact ? arrayMemory.Retain(0, length, borrow) : arrayMemory.Retain(0, arrayMemory.Length, borrow);
        }

        /// <summary>
        /// Return a contiguous segment of memory backed by a pooled memory from a shares array pool.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RetainedMemory<byte> Retain(int length, bool requireExact = true)
        {
            return Shared.RetainMemory(length, requireExact);
        }

        /// <summary>
        /// Retains memory for temporary usage. Actual length could be larger than requested.
        /// When requested length is above 64kb then off-heap memory is used.
        /// </summary>
        internal static RetainedMemory<byte> RetainTemp(int length)
        {
            
            if (length > Settings.LARGE_BUFFER_LIMIT)
            {
                // TODO Adjust per-core count in the main pool to 1 when size >  Settings.LARGE_BUFFER_LIMIT)
                // if (OffHeapMemoryPool != null)
                // {
                //     var mem = OffHeapMemoryPool.RentMemory(length);
                //     if (mem.IsDisposed)
                //     {
                //         BuffersThrowHelper.ThrowDisposed<OffHeapMemory<byte>>();
                //     }
                //     return mem.Retain(0, mem.Length, borrow: false);
                // }
            }
            var rm = Shared.RetainMemory(length, false, false);
            Debug.Assert(rm.IsPinned);
            return rm;
        }
    }

    internal static class BufferPoolRetainedMemoryHelper<T>
    {
        // ReSharper disable once StaticMemberInGenericType
        public static readonly bool IsRetainedMemory = IsRetainedMemoryInit();

        public static void DisposeRetainedMemory(T[] array, int offset, int len)
        {
            // TODO assert here
            for (int i = offset; i < offset + len; i++)
            {
#if SPREADS
                // TODO test it!
                Native.UnsafeEx.DisposeConstrained(ref array[i]); // ((IDisposable)array[i]).Dispose();
#else
                (array[i] as IDisposable)?.Dispose();
#endif
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static bool IsRetainedMemoryInit()
        {
            var ti = typeof(T).GetTypeInfo();
            if (ti.IsGenericTypeDefinition)
            {
                return ti.GetGenericTypeDefinition() == typeof(RetainedMemory<>);
            }
            else
            {
                return false;
            }
        }
    }
}
