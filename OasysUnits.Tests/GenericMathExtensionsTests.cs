﻿// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/OasysUnits.

#if NET7_0_OR_GREATER
using OasysUnits.GenericMath;
using Xunit;

namespace OasysUnits.Tests;

public class GenericMathExtensionsTests
{
    [Fact]
    public void CanCalcSum()
    {
        Length[] values = { Length.FromCentimeters(100), Length.FromCentimeters(200) };

        Assert.Equal(Length.FromCentimeters(300), values.Sum());
    }

    [Fact]
    public void CanCalcAverage_ForQuantitiesWithDoubleValueType()
    {
        Length[] values = { Length.FromCentimeters(100), Length.FromCentimeters(200) };

        Assert.Equal(Length.FromCentimeters(150), values.Average());
    }
}

#endif
