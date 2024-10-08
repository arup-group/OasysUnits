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

using OasysUnits.NumberExtensions.NumberToElectricPotential;
using Xunit;

namespace OasysUnits.Tests
{
    public class NumberToElectricPotentialExtensionsTests
    {
        [Fact]
        public void NumberToKilovoltsTest() =>
            Assert.Equal(ElectricPotential.FromKilovolts(2), 2.Kilovolts());

        [Fact]
        public void NumberToMegavoltsTest() =>
            Assert.Equal(ElectricPotential.FromMegavolts(2), 2.Megavolts());

        [Fact]
        public void NumberToMicrovoltsTest() =>
            Assert.Equal(ElectricPotential.FromMicrovolts(2), 2.Microvolts());

        [Fact]
        public void NumberToMillivoltsTest() =>
            Assert.Equal(ElectricPotential.FromMillivolts(2), 2.Millivolts());

        [Fact]
        public void NumberToNanovoltsTest() =>
            Assert.Equal(ElectricPotential.FromNanovolts(2), 2.Nanovolts());

        [Fact]
        public void NumberToVoltsTest() =>
            Assert.Equal(ElectricPotential.FromVolts(2), 2.Volts());

    }
}
