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

using OasysUnits.NumberExtensions.NumberToArea;
using Xunit;

namespace OasysUnits.Tests
{
    public class NumberToAreaExtensionsTests
    {
        [Fact]
        public void NumberToAcresTest() =>
            Assert.Equal(Area.FromAcres(2), 2.Acres());

        [Fact]
        public void NumberToHectaresTest() =>
            Assert.Equal(Area.FromHectares(2), 2.Hectares());

        [Fact]
        public void NumberToSquareCentimetersTest() =>
            Assert.Equal(Area.FromSquareCentimeters(2), 2.SquareCentimeters());

        [Fact]
        public void NumberToSquareDecimetersTest() =>
            Assert.Equal(Area.FromSquareDecimeters(2), 2.SquareDecimeters());

        [Fact]
        public void NumberToSquareFeetTest() =>
            Assert.Equal(Area.FromSquareFeet(2), 2.SquareFeet());

        [Fact]
        public void NumberToSquareInchesTest() =>
            Assert.Equal(Area.FromSquareInches(2), 2.SquareInches());

        [Fact]
        public void NumberToSquareKilometersTest() =>
            Assert.Equal(Area.FromSquareKilometers(2), 2.SquareKilometers());

        [Fact]
        public void NumberToSquareMetersTest() =>
            Assert.Equal(Area.FromSquareMeters(2), 2.SquareMeters());

        [Fact]
        public void NumberToSquareMicrometersTest() =>
            Assert.Equal(Area.FromSquareMicrometers(2), 2.SquareMicrometers());

        [Fact]
        public void NumberToSquareMilesTest() =>
            Assert.Equal(Area.FromSquareMiles(2), 2.SquareMiles());

        [Fact]
        public void NumberToSquareMillimetersTest() =>
            Assert.Equal(Area.FromSquareMillimeters(2), 2.SquareMillimeters());

        [Fact]
        public void NumberToSquareNauticalMilesTest() =>
            Assert.Equal(Area.FromSquareNauticalMiles(2), 2.SquareNauticalMiles());

        [Fact]
        public void NumberToSquareYardsTest() =>
            Assert.Equal(Area.FromSquareYards(2), 2.SquareYards());

        [Fact]
        public void NumberToUsSurveySquareFeetTest() =>
            Assert.Equal(Area.FromUsSurveySquareFeet(2), 2.UsSurveySquareFeet());

    }
}
