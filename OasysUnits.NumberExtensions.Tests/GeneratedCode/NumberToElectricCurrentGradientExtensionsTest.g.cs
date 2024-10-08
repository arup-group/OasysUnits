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

using OasysUnits.NumberExtensions.NumberToElectricCurrentGradient;
using Xunit;

namespace OasysUnits.Tests
{
    public class NumberToElectricCurrentGradientExtensionsTests
    {
        [Fact]
        public void NumberToAmperesPerMicrosecondTest() =>
            Assert.Equal(ElectricCurrentGradient.FromAmperesPerMicrosecond(2), 2.AmperesPerMicrosecond());

        [Fact]
        public void NumberToAmperesPerMillisecondTest() =>
            Assert.Equal(ElectricCurrentGradient.FromAmperesPerMillisecond(2), 2.AmperesPerMillisecond());

        [Fact]
        public void NumberToAmperesPerMinuteTest() =>
            Assert.Equal(ElectricCurrentGradient.FromAmperesPerMinute(2), 2.AmperesPerMinute());

        [Fact]
        public void NumberToAmperesPerNanosecondTest() =>
            Assert.Equal(ElectricCurrentGradient.FromAmperesPerNanosecond(2), 2.AmperesPerNanosecond());

        [Fact]
        public void NumberToAmperesPerSecondTest() =>
            Assert.Equal(ElectricCurrentGradient.FromAmperesPerSecond(2), 2.AmperesPerSecond());

        [Fact]
        public void NumberToMilliamperesPerMinuteTest() =>
            Assert.Equal(ElectricCurrentGradient.FromMilliamperesPerMinute(2), 2.MilliamperesPerMinute());

        [Fact]
        public void NumberToMilliamperesPerSecondTest() =>
            Assert.Equal(ElectricCurrentGradient.FromMilliamperesPerSecond(2), 2.MilliamperesPerSecond());

    }
}
