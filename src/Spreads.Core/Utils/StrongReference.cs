﻿// This Source Code Form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this
// file, You can obtain one at http://mozilla.org/MPL/2.0/.

using System.Runtime.CompilerServices;

namespace Spreads.Utils
{
    internal sealed class StrongReference<T> where T : class
    {
        public StrongReference(T target)
        {
            Target = target;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryGetTarget(out T target)
        {
            // Call the worker method that has more performant but less user friendly signature.
            T o = Target;
            target = o;
            return o != null;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetTarget(T target)
        {
            Target = target;
        }

        // This is property for better debugging experience (VS debugger shows values of properties when you hover over the variables)
        private T Target
        {
            get; set;
        }
    }
}