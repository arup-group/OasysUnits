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

using OasysUnits.NumberExtensions.NumberToMolarFlow;
using Xunit;

namespace OasysUnits.Tests
{
    public class NumberToMolarFlowExtensionsTests
    {
        [Fact]
        public void NumberToKilomolesPerHourTest() =>
            Assert.Equal(MolarFlow.FromKilomolesPerHour(2), 2.KilomolesPerHour());

        [Fact]
        public void NumberToKilomolesPerMinuteTest() =>
            Assert.Equal(MolarFlow.FromKilomolesPerMinute(2), 2.KilomolesPerMinute());

        [Fact]
        public void NumberToKilomolesPerSecondTest() =>
            Assert.Equal(MolarFlow.FromKilomolesPerSecond(2), 2.KilomolesPerSecond());

        [Fact]
        public void NumberToMolesPerHourTest() =>
            Assert.Equal(MolarFlow.FromMolesPerHour(2), 2.MolesPerHour());

        [Fact]
        public void NumberToMolesPerMinuteTest() =>
            Assert.Equal(MolarFlow.FromMolesPerMinute(2), 2.MolesPerMinute());

        [Fact]
        public void NumberToMolesPerSecondTest() =>
            Assert.Equal(MolarFlow.FromMolesPerSecond(2), 2.MolesPerSecond());

        [Fact]
        public void NumberToPoundMolesPerHourTest() =>
            Assert.Equal(MolarFlow.FromPoundMolesPerHour(2), 2.PoundMolesPerHour());

        [Fact]
        public void NumberToPoundMolesPerMinuteTest() =>
            Assert.Equal(MolarFlow.FromPoundMolesPerMinute(2), 2.PoundMolesPerMinute());

        [Fact]
        public void NumberToPoundMolesPerSecondTest() =>
            Assert.Equal(MolarFlow.FromPoundMolesPerSecond(2), 2.PoundMolesPerSecond());

    }
}
