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

using OasysUnits.NumberExtensions.NumberToMolarity;
using Xunit;

namespace OasysUnits.Tests
{
    public class NumberToMolarityExtensionsTests
    {
        [Fact]
        public void NumberToCentimolesPerLiterTest() =>
            Assert.Equal(Molarity.FromCentimolesPerLiter(2), 2.CentimolesPerLiter());

        [Fact]
        public void NumberToDecimolesPerLiterTest() =>
            Assert.Equal(Molarity.FromDecimolesPerLiter(2), 2.DecimolesPerLiter());

        [Fact]
        public void NumberToFemtomolesPerLiterTest() =>
            Assert.Equal(Molarity.FromFemtomolesPerLiter(2), 2.FemtomolesPerLiter());

        [Fact]
        public void NumberToKilomolesPerCubicMeterTest() =>
            Assert.Equal(Molarity.FromKilomolesPerCubicMeter(2), 2.KilomolesPerCubicMeter());

        [Fact]
        public void NumberToMicromolesPerLiterTest() =>
            Assert.Equal(Molarity.FromMicromolesPerLiter(2), 2.MicromolesPerLiter());

        [Fact]
        public void NumberToMillimolesPerLiterTest() =>
            Assert.Equal(Molarity.FromMillimolesPerLiter(2), 2.MillimolesPerLiter());

        [Fact]
        public void NumberToMolesPerCubicMeterTest() =>
            Assert.Equal(Molarity.FromMolesPerCubicMeter(2), 2.MolesPerCubicMeter());

        [Fact]
        public void NumberToMolesPerLiterTest() =>
            Assert.Equal(Molarity.FromMolesPerLiter(2), 2.MolesPerLiter());

        [Fact]
        public void NumberToNanomolesPerLiterTest() =>
            Assert.Equal(Molarity.FromNanomolesPerLiter(2), 2.NanomolesPerLiter());

        [Fact]
        public void NumberToPicomolesPerLiterTest() =>
            Assert.Equal(Molarity.FromPicomolesPerLiter(2), 2.PicomolesPerLiter());

        [Fact]
        public void NumberToPoundMolesPerCubicFootTest() =>
            Assert.Equal(Molarity.FromPoundMolesPerCubicFoot(2), 2.PoundMolesPerCubicFoot());

    }
}
