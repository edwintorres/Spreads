﻿using System;
using System.Runtime.CompilerServices;
using NUnit.Framework;
using Spreads.Buffers;
using Spreads.Native;
using Spreads.Utils;

namespace Spreads.Core.Tests.Buffers
{
    [Category("CI")]
    [TestFixture]
    public class RetainableMemoryMemoryAccessBench
    {

        [Test
#if !DEBUG
         , Explicit("bench")
#endif
        ]
#if NETCOREAPP3_0
        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
#endif
        public void MemoryAccessBench()
        {
            var count = (int)TestUtils.GetBenchCount(500_000_000);
            var rm = PrivateMemory<int>.Create(count);
            for (int i = 0; i < count; i++)
            {
                rm.Vec.DangerousGetRef<int>(i) = i;
            }

            for (int r = 0; r < 10 ; r++)
            {
                MemoryAccessViaPointer(rm);
                MemoryAccessVecViaFieldDangerous(rm);
                MemoryAccessVecViaLocalDangerous(rm);
                MemoryAccessVecViaLocalUnsafe(rm);
                MemoryAccessVecViaHelperUnsafe(rm);
                MemoryAccessVecViaDbHelperUnsafe(rm);
                MemoryAccessVecViaDbHelperDangerous(rm);
                MemoryAccessVecViaDbHelperUnsafeGetRef(rm);
                MemoryAccessVecViaDbVecUnsafe(rm);
                MemoryAccessVecViaDbVecPointer(rm);
                MemoryAccessVecViaDbVecDangerous(rm);
                MemoryAccessVecViaDbVecStorageUnsafe(rm);
                MemoryAccessVecViaDbVecStorageDangerous(rm);
            }

            Benchmark.Dump();
            rm.Dispose();
        }

#if NETCOREAPP3_0
        [MethodImpl(MethodImplOptions.AggressiveOptimization | MethodImplOptions.NoInlining)]
#endif
        public unsafe void MemoryAccessViaPointer(RetainableMemory<int> rm)
        {
            long sum = 0;
            using (Benchmark.Run("Pointer", rm.Length))
            {
                var ptr = (int*) rm.Pointer;
                for (int i = 0; i < rm.Length; i++)
                {
                    sum += ptr[i];
                }
            }

            if (sum < 1000)
                throw new InvalidOperationException();
        }

#if NETCOREAPP3_0
        [MethodImpl(MethodImplOptions.AggressiveOptimization | MethodImplOptions.NoInlining)]
#endif
        public void MemoryAccessVecViaFieldDangerous(RetainableMemory<int> rm)
        {
            long sum = 0;
            using (Benchmark.Run("FieldUnsafe", rm.Length))
            {
                for (int i = 0; i < rm.Length; i++)
                {
                    sum += rm.Vec.UnsafeGetUnaligned<int>(i);
                }
            }

            if (sum < 1000)
                throw new InvalidOperationException();
        }

#if NETCOREAPP3_0
        [MethodImpl(MethodImplOptions.AggressiveOptimization | MethodImplOptions.NoInlining)]
#endif
        public void MemoryAccessVecViaLocalDangerous(RetainableMemory<int> rm)
        {
            long sum = 0;
            using (Benchmark.Run("LocalDangerous", rm.Length))
            {
                var vec = rm.Vec;
                for (int i = 0; i < rm.Length; i++)
                {
                    sum += vec.DangerousGetUnaligned<int>(i);
                }
            }

            if (sum < 1000)
                throw new InvalidOperationException();
        }

#if NETCOREAPP3_0
        [MethodImpl(MethodImplOptions.AggressiveOptimization | MethodImplOptions.NoInlining)]
#endif
        public void MemoryAccessVecViaLocalUnsafe(RetainableMemory<int> rm)
        {
            long sum = 0;
            using (Benchmark.Run("LocalUnsafe", rm.Length))
            {
                var vec = rm.Vec;
                for (int i = 0; i < rm.Length; i++)
                {
                    sum += vec.UnsafeGetUnaligned<int>(i);
                }
            }

            if (sum < 1000)
                throw new InvalidOperationException();
        }

#if NETCOREAPP3_0
        [MethodImpl(MethodImplOptions.AggressiveOptimization | MethodImplOptions.NoInlining)]
#endif
        public void MemoryAccessVecViaHelperUnsafe(RetainableMemory<int> rm)
        {
            long sum = 0;
            using (Benchmark.Run("HelperUnsafe", rm.Length))
            {
                object obj = rm;
                for (int i = 0; i < rm.Length; i++)
                {
                    sum += RetainableMemoryHelper.GetVecRef(obj).UnsafeGetUnaligned<int>(i);
                }
            }

            if (sum < 1000)
                throw new InvalidOperationException();
        }

#if NETCOREAPP3_0
        [MethodImpl(MethodImplOptions.AggressiveOptimization | MethodImplOptions.NoInlining)]
#endif
        public void MemoryAccessVecViaDbHelperUnsafe(RetainableMemory<int> rm)
        {
            long sum = 0;
            using (Benchmark.Run("DbHelperUnsafe (^)", rm.Length))
            {
                DataBlockLike db = new DataBlockLike {RM = rm};
                for (int i = 0; i < rm.Length; i++)
                {
                    sum += RetainableMemoryHelper.GetVecRef(db.RM).UnsafeGetUnaligned<int>(i);
                }
            }

            if (sum < 1000)
                throw new InvalidOperationException();
        }
        
#if NETCOREAPP3_0
        [MethodImpl(MethodImplOptions.AggressiveOptimization | MethodImplOptions.NoInlining)]
#endif
        public void MemoryAccessVecViaDbHelperDangerous(RetainableMemory<int> rm)
        {
            long sum = 0;
            using (Benchmark.Run("DbHelperDangerous (^)", rm.Length))
            {
                DataBlockLike db = new DataBlockLike {RM = rm};
                for (int i = 0; i < rm.Length; i++)
                {
                    sum += RetainableMemoryHelper.GetVecRef(db.RM).DangerousGetUnaligned<int>(i);
                }
            }

            if (sum < 1000)
                throw new InvalidOperationException();
        }
        
#if NETCOREAPP3_0
        [MethodImpl(MethodImplOptions.AggressiveOptimization | MethodImplOptions.NoInlining)]
#endif
        public void MemoryAccessVecViaDbHelperUnsafeGetRef(RetainableMemory<int> rm)
        {
            long sum = 0;
            using (Benchmark.Run("DbHelperUnsafeGet (^)", rm.Length))
            {
                DataBlockLike db = new DataBlockLike {RM = rm};
                for (int i = 0; i < rm.Length; i++)
                {
                    sum += RetainableMemoryHelper.UnsafeGet<int>(rm, i);
                }
            }

            if (sum < 1000)
                throw new InvalidOperationException();
        }
        
#if NETCOREAPP3_0
        [MethodImpl(MethodImplOptions.AggressiveOptimization | MethodImplOptions.NoInlining)]
#endif
        public void MemoryAccessVecViaDbVecDangerous(RetainableMemory<int> rm)
        {
            long sum = 0;
            using (Benchmark.Run("DbVecDangerous (+)", rm.Length))
            {
                DataBlockLike db = new DataBlockLike {RM = rm, Vec = rm.Vec};
                for (int i = 0; i < rm.Length; i++)
                {
                    sum += db.Vec.DangerousGetUnaligned<int>(i);
                }
            }

            if (sum < 1000)
                throw new InvalidOperationException();
        }
        
#if NETCOREAPP3_0
        [MethodImpl(MethodImplOptions.AggressiveOptimization | MethodImplOptions.NoInlining)]
#endif
        public void MemoryAccessVecViaDbVecUnsafe(RetainableMemory<int> rm)
        {
            long sum = 0;
            using (Benchmark.Run("DbVecUnsafe (+)", rm.Length))
            {
                DataBlockLike db = new DataBlockLike {RM = rm, Vec = rm.Vec};
                for (int i = 0; i < rm.Length; i++)
                {
                    sum += db.Vec.UnsafeGetUnaligned<int>(i);
                }
            }

            if (sum < 1000)
                throw new InvalidOperationException();
        }
        
#if NETCOREAPP3_0
        [MethodImpl(MethodImplOptions.AggressiveOptimization | MethodImplOptions.NoInlining)]
#endif
        public unsafe void MemoryAccessVecViaDbVecPointer(RetainableMemory<int> rm)
        {
            long sum = 0;
            using (Benchmark.Run("DbVecPointer", rm.Length))
            {
                DataBlockLike db = new DataBlockLike {RM = rm, Vec = rm.Vec, Ptr = (int*)rm.Pointer};
                for (int i = 0; i < rm.Length; i++)
                {
                    sum += db.Ptr[i];
                }
            }

            if (sum < 1000)
                throw new InvalidOperationException();
        }
        
#if NETCOREAPP3_0
        [MethodImpl(MethodImplOptions.AggressiveOptimization | MethodImplOptions.NoInlining)]
#endif
        public void MemoryAccessVecViaDbVecStorageUnsafe(RetainableMemory<int> rm)
        {
            long sum = 0;
            using (Benchmark.Run("DbVecStorageUnsafe (_)", rm.Length))
            {
                DataBlockLike db = new DataBlockLike {RM = rm, Vec = rm.Vec, VecStorage = VecStorage.Create(rm, 0, rm.Length, true)};
                for (int i = 0; i < rm.Length; i++)
                {
                    sum += db.VecStorage.Vec.UnsafeGetUnaligned<int>(i);
                }
            }

            if (sum < 1000)
                throw new InvalidOperationException();
        }
        
#if NETCOREAPP3_0
        [MethodImpl(MethodImplOptions.AggressiveOptimization | MethodImplOptions.NoInlining)]
#endif
        public void MemoryAccessVecViaDbVecStorageDangerous(RetainableMemory<int> rm)
        {
            long sum = 0;
            using (Benchmark.Run("DbVecStorageDangerous (_)", rm.Length))
            {
                DataBlockLike db = new DataBlockLike {RM = rm, Vec = rm.Vec, VecStorage = VecStorage.Create(rm, 0, rm.Length, true)};
                for (int i = 0; i < rm.Length; i++)
                {
                    sum += db.VecStorage.Vec.DangerousGetUnaligned<int>(i);
                }
            }

            if (sum < 1000)
                throw new InvalidOperationException();
        }

        internal unsafe class DataBlockLike
        {
            public object RM;
            public VecStorage VecStorage;
            public Vec Vec;
            public int* Ptr;
        }
    }
}