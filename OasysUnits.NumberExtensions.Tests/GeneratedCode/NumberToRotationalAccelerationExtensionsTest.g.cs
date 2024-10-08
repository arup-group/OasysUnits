//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add UnitDefinitions\MyQuantity.json and run generate-code.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using OasysUnits.NumberExtensions.NumberToRotationalAcceleration;
using Xunit;

namespace OasysUnits.Tests
{
    public class NumberToRotationalAccelerationExtensionsTests
    {
        [Fact]
        public void NumberToDegreesPerSecondSquaredTest() =>
            Assert.Equal(RotationalAcceleration.FromDegreesPerSecondSquared(2), 2.DegreesPerSecondSquared());

        [Fact]
        public void NumberToRadiansPerSecondSquaredTest() =>
            Assert.Equal(RotationalAcceleration.FromRadiansPerSecondSquared(2), 2.RadiansPerSecondSquared());

        [Fact]
        public void NumberToRevolutionsPerMinutePerSecondTest() =>
            Assert.Equal(RotationalAcceleration.FromRevolutionsPerMinutePerSecond(2), 2.RevolutionsPerMinutePerSecond());

        [Fact]
        public void NumberToRevolutionsPerSecondSquaredTest() =>
            Assert.Equal(RotationalAcceleration.FromRevolutionsPerSecondSquared(2), 2.RevolutionsPerSecondSquared());

    }
}
