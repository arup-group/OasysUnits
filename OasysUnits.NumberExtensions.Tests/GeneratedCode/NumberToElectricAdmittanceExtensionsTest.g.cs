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

using OasysUnits.NumberExtensions.NumberToElectricAdmittance;
using Xunit;

namespace OasysUnits.Tests
{
    public class NumberToElectricAdmittanceExtensionsTests
    {
        [Fact]
        public void NumberToMicrosiemensTest() =>
            Assert.Equal(ElectricAdmittance.FromMicrosiemens(2), 2.Microsiemens());

        [Fact]
        public void NumberToMillisiemensTest() =>
            Assert.Equal(ElectricAdmittance.FromMillisiemens(2), 2.Millisiemens());

        [Fact]
        public void NumberToNanosiemensTest() =>
            Assert.Equal(ElectricAdmittance.FromNanosiemens(2), 2.Nanosiemens());

        [Fact]
        public void NumberToSiemensTest() =>
            Assert.Equal(ElectricAdmittance.FromSiemens(2), 2.Siemens());

    }
}
