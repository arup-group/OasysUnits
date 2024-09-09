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

using OasysUnits.NumberExtensions.NumberToMolality;
using Xunit;

namespace OasysUnits.Tests
{
    public class NumberToMolalityExtensionsTests
    {
        [Fact]
        public void NumberToMillimolesPerKilogramTest() =>
            Assert.Equal(Molality.FromMillimolesPerKilogram(2), 2.MillimolesPerKilogram());

        [Fact]
        public void NumberToMolesPerGramTest() =>
            Assert.Equal(Molality.FromMolesPerGram(2), 2.MolesPerGram());

        [Fact]
        public void NumberToMolesPerKilogramTest() =>
            Assert.Equal(Molality.FromMolesPerKilogram(2), 2.MolesPerKilogram());

    }
}
