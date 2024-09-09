﻿//------------------------------------------------------------------------------
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

using System;
using Xunit;

namespace OasysUnits.Tests.CustomCode
{
    public class LuminanceTests : LuminanceTestsBase
    {
        protected override bool SupportsSIUnitSystem => true;
        protected override double CandelasPerSquareMeterInOneCandelaPerSquareMeter => 1;
        protected override double CandelasPerSquareFootInOneCandelaPerSquareMeter => 9.290304e-2;
        protected override double CandelasPerSquareInchInOneCandelaPerSquareMeter => 6.4516e-4;
        protected override double KilocandelasPerSquareMeterInOneCandelaPerSquareMeter => 1e-3;
        protected override double DecicandelasPerSquareMeterInOneCandelaPerSquareMeter => 1e1;
        protected override double CenticandelasPerSquareMeterInOneCandelaPerSquareMeter => 1e2;
        protected override double MillicandelasPerSquareMeterInOneCandelaPerSquareMeter => 1e3;
        protected override double MicrocandelasPerSquareMeterInOneCandelaPerSquareMeter => 1e6;
        protected override double NanocandelasPerSquareMeterInOneCandelaPerSquareMeter => 1e9;
        protected override double NitsInOneCandelaPerSquareMeter => 1;

        [Fact]
        public void LuminanceTimesAreaEqualsLuminousIntensity()
        {
            LuminousIntensity luminousIntensity = Luminance.FromCandelasPerSquareMeter(3) * Area.FromSquareMeters(4);
            Assert.Equal(luminousIntensity, LuminousIntensity.FromCandela(12));
        }

        [Fact]
        public void LuminousIntensityDividedByAreaEqualsLuminance()
        {
            Luminance luminance = LuminousIntensity.FromCandela(12) / Area.FromSquareMeters(4);
            Assert.Equal(luminance, Luminance.FromCandelasPerSquareMeter(3));
        }

        [Fact]
        public void LuminousIntensityDividedByLuminanceEqualsArea()
        {
            Area area = LuminousIntensity.FromCandela(12) / Luminance.FromCandelasPerSquareMeter(4);
            Assert.Equal(area, Area.FromSquareMeters(3));
        }
    }
}
