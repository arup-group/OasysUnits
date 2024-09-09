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

using OasysUnits.NumberExtensions.NumberToTemperatureDelta;
using Xunit;

namespace OasysUnits.Tests
{
    public class NumberToTemperatureDeltaExtensionsTests
    {
        [Fact]
        public void NumberToDegreesCelsiusTest() =>
            Assert.Equal(TemperatureDelta.FromDegreesCelsius(2), 2.DegreesCelsius());

        [Fact]
        public void NumberToDegreesDelisleTest() =>
            Assert.Equal(TemperatureDelta.FromDegreesDelisle(2), 2.DegreesDelisle());

        [Fact]
        public void NumberToDegreesFahrenheitTest() =>
            Assert.Equal(TemperatureDelta.FromDegreesFahrenheit(2), 2.DegreesFahrenheit());

        [Fact]
        public void NumberToDegreesNewtonTest() =>
            Assert.Equal(TemperatureDelta.FromDegreesNewton(2), 2.DegreesNewton());

        [Fact]
        public void NumberToDegreesRankineTest() =>
            Assert.Equal(TemperatureDelta.FromDegreesRankine(2), 2.DegreesRankine());

        [Fact]
        public void NumberToDegreesReaumurTest() =>
            Assert.Equal(TemperatureDelta.FromDegreesReaumur(2), 2.DegreesReaumur());

        [Fact]
        public void NumberToDegreesRoemerTest() =>
            Assert.Equal(TemperatureDelta.FromDegreesRoemer(2), 2.DegreesRoemer());

        [Fact]
        public void NumberToKelvinsTest() =>
            Assert.Equal(TemperatureDelta.FromKelvins(2), 2.Kelvins());

        [Fact]
        public void NumberToMillidegreesCelsiusTest() =>
            Assert.Equal(TemperatureDelta.FromMillidegreesCelsius(2), 2.MillidegreesCelsius());

    }
}
