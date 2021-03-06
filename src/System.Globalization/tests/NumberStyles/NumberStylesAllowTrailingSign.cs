// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Globalization;
using Xunit;

namespace System.Globalization.Tests
{
    public class NumberStylesAllowTrailingSign
    {
        // PosTest1: Verify value of NumberStyles.AllowTrailingSign
        [Fact]
        public void TestAllowTrailingSign()
        {
            int expected = 0x00000008;
            int actual = (int)NumberStyles.AllowTrailingSign;
            Assert.Equal(expected, actual);
        }
    }
}
