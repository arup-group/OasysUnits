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

using OasysUnits.NumberExtensions.NumberToCurvature;
using Xunit;

namespace OasysUnits.Tests
{
    public class NumberToCurvatureExtensionsTests
    {
        [Fact]
        public void NumberToPerCentimetersTest() =>
            Assert.Equal(Curvature.FromPerCentimeters(2), 2.PerCentimeters());

        [Fact]
        public void NumberToPerFeetTest() =>
            Assert.Equal(Curvature.FromPerFeet(2), 2.PerFeet());

        [Fact]
        public void NumberToPerInchesTest() =>
            Assert.Equal(Curvature.FromPerInches(2), 2.PerInches());

        [Fact]
        public void NumberToPerMetersTest() =>
            Assert.Equal(Curvature.FromPerMeters(2), 2.PerMeters());

        [Fact]
        public void NumberToPerMillimetersTest() =>
            Assert.Equal(Curvature.FromPerMillimeters(2), 2.PerMillimeters());

    }
}
