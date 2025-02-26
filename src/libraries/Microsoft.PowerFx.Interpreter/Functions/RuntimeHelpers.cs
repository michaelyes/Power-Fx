﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using Microsoft.PowerFx.Core.IR;
using Microsoft.PowerFx.Core.Public.Values;

namespace Microsoft.PowerFx.Functions
{
    // Core operations for runtime implemenation
    internal static class RuntimeHelpers
    {
        public static bool AreEqual(FormulaValue arg1, FormulaValue arg2)
        {
            bool b;
            if (arg1 is BlankValue) // $$$ coercion 
            {
                b = arg2 is BlankValue;
            }
            else
            {
                b = arg1.ToObject().Equals(arg2.ToObject());
            }
            return b;
        }

        public static StringValue ConcatString(IRContext irContext, StringValue arg1, StringValue arg2)
        {
            var str = string.Concat(arg1.Value, arg2.Value);
            return new StringValue(irContext, str);
        }
    }
}