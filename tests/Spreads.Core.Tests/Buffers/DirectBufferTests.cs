﻿// This Source Code Form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this
// file, You can obtain one at http://mozilla.org/MPL/2.0/.

using NUnit.Framework;
using Spreads.Buffers;
using System;

namespace Spreads.Core.Tests.Buffers
{
    [Category("CI")]
    [TestFixture]
    public class DirectBufferTests
    {
        [Test]
        public void CouldCompareDbs()
        {
            for (int i = 0; i < 20; i++)
            {
                var rm0 = BufferPool.Retain(1 << i, true);
                var rm1 = BufferPool.Retain(1 << i, true);

                var db0 = rm0.ToDirectBuffer();
                var db1 = rm1.ToDirectBuffer();

                db0.Clear(0, db0.Length);
                db1.Clear(0, db1.Length);

                Assert.IsTrue(db0.Equals(db0));
                Assert.IsTrue(db0.Equals(db1));

                rm0.Dispose();
                rm1.Dispose();

                GC.Collect(2, GCCollectionMode.Forced, true, true);
                GC.WaitForPendingFinalizers();
                GC.Collect(2, GCCollectionMode.Forced, true, true);
                GC.WaitForPendingFinalizers();
            }
        }

        [Test]
        public void CouldFillDbs()
        {
            for (int i = 0; i < 20; i++)
            {
                var rm0 = BufferPool.Retain(1 << i, true);
                var rm1 = BufferPool.Retain(1 << i, true);

                var db0 = rm0.ToDirectBuffer();
                var db1 = rm1.ToDirectBuffer();

                db0.Clear(0, db0.Length);
                db1.Clear(0, db1.Length);

                Assert.IsTrue(db0.IsFilledWithValue(0));
                Assert.IsTrue(db1.IsFilledWithValue(0));

                Assert.IsTrue(db0.Equals(db0));
                Assert.IsTrue(db0.Equals(db1));

                db0.Fill(0, db1.Length, 1);

                Assert.IsFalse(db0.Equals(db1));
                Assert.IsTrue(db0.IsFilledWithValue(1));

                db1.Fill(0, db1.Length, 1);
                Assert.IsTrue(db0.Equals(db0));

                rm0.Dispose();
                rm1.Dispose();
            }
        }
    }
}
