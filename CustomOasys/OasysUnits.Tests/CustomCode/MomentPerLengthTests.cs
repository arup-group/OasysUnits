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
    public class MomentPerLengthTests : MomentPerLengthTestsBase
    {
        protected override bool SupportsSIUnitSystem => false;
        protected override double KilogramForceCentimetersPerCentimeterInOneNewtonMeterPerMeter => 0.101971621;
        protected override double KilogramForceMetersPerCentimeterInOneNewtonMeterPerMeter => 0.00101971621;
        protected override double KilogramForceMetersPerMeterInOneNewtonMeterPerMeter => 0.101971621;
        protected override double KilogramForceMetersPerMillimeterInOneNewtonMeterPerMeter => 0.000101971621;
        protected override double KilogramForceMillimetersPerMillimeterInOneNewtonMeterPerMeter => 0.101971621;
        protected override double KilonewtonCentimetersPerCentimeterInOneNewtonMeterPerMeter => 0.001;
        protected override double KilonewtonMetersPerCentimeterInOneNewtonMeterPerMeter => 0.00001;
        protected override double KilonewtonMetersPerMeterInOneNewtonMeterPerMeter => 0.001;
        protected override double KilonewtonMetersPerMillimeterInOneNewtonMeterPerMeter => 0.000001;
        protected override double KilonewtonMillimetersPerMillimeterInOneNewtonMeterPerMeter => 0.001;
        protected override double KilopoundForceFeetPerFootInOneNewtonMeterPerMeter => 0.00022481;
        protected override double KilopoundForceFeetPerInchInOneNewtonMeterPerMeter => 0.000018734167;
        protected override double KilopoundForceInchesPerInchInOneNewtonMeterPerMeter => 0.00022481;
        protected override double MeganewtonCentimetersPerCentimeterInOneNewtonMeterPerMeter => 1E-6;
        protected override double MeganewtonMetersPerCentimeterInOneNewtonMeterPerMeter => 1E-8;
        protected override double MeganewtonMetersPerMeterInOneNewtonMeterPerMeter => 1E-6;
        protected override double MeganewtonMetersPerMillimeterInOneNewtonMeterPerMeter => 1E-9;
        protected override double MeganewtonMillimetersPerMillimeterInOneNewtonMeterPerMeter => 1E-6;
        protected override double NewtonCentimetersPerCentimeterInOneNewtonMeterPerMeter => 1;
        protected override double NewtonMetersPerCentimeterInOneNewtonMeterPerMeter => 0.01;
        protected override double NewtonMetersPerMeterInOneNewtonMeterPerMeter => 1;
        protected override double NewtonMetersPerMillimeterInOneNewtonMeterPerMeter => 0.001;
        protected override double NewtonMillimetersPerMillimeterInOneNewtonMeterPerMeter => 1;
        protected override double PoundForceFeetPerFootInOneNewtonMeterPerMeter => 0.22481;
        protected override double PoundForceFeetPerInchInOneNewtonMeterPerMeter => 0.018734167;
        protected override double PoundForceFeetPerYardInOneNewtonMeterPerMeter => 0.67443;
        protected override double PoundForceInchesPerInchInOneNewtonMeterPerMeter => 0.22481;
        protected override double TonneForceCentimetersPerCentimeterInOneNewtonMeterPerMeter => 1.01972e-4;
        protected override double TonneForceMetersPerCentimeterInOneNewtonMeterPerMeter => 1.01972e-6;
        protected override double TonneForceMetersPerMeterInOneNewtonMeterPerMeter => 1.01972e-4;
        protected override double TonneForceMetersPerMillimeterInOneNewtonMeterPerMeter => 1.01972e-7;
        protected override double TonneForceMillimetersPerMillimeterInOneNewtonMeterPerMeter => 1.01972e-4;

        // copied from ForceTests
        private double KilogramsForceInOneNewton => 0.101972;
        private double KilopoundsForceInOneNewton => 0.22481e-3;
        private double MeganewtonsInOneNewton => 1E-6;
        private double KilonewtonsInOneNewton => 1E-3;
        private double NewtonsInOneNewton => 1;
        private double PoundsForceInOneNewton => 0.22481;
        private double TonnesForceInOneNewton => 1.019716212977928e-4;

        //copied from LengthTests
        private double FeetInOneMeter => 3.28084;
        private double InchesInOneMeter => 39.37007874;
        private double YardsInOneMeter => 1.09361;

        [Fact]
        public void KilogramForceCentimetersPerCentimeterInOneNewtonMeterPerMeterTest()
        {
            double expected = KilogramsForceInOneNewton;
            Assert.Equal(expected, KilogramForceCentimetersPerCentimeterInOneNewtonMeterPerMeter, 6);
        }

        [Fact]
        public void KilogramForceMetersPerCentimeterInOneNewtonMeterPerMeterTest()
        {
            double expected = KilogramsForceInOneNewton / 100.0;
            Assert.Equal(expected, KilogramForceMetersPerCentimeterInOneNewtonMeterPerMeter, 6);
        }

        [Fact]
        public void KilogramForceMetersPerMeterInOneNewtonMeterPerMeterTest()
        {
            double expected = KilogramsForceInOneNewton;
            Assert.Equal(expected, KilogramForceMetersPerMeterInOneNewtonMeterPerMeter, 6);
        }

        [Fact]
        public void KilogramForceMetersPerMillimeterInOneNewtonMeterPerMeterTest()
        {
            double expected = KilogramsForceInOneNewton / 1000.0;
            Assert.Equal(expected, KilogramForceMetersPerMillimeterInOneNewtonMeterPerMeter, 6);
        }

        [Fact]
        public void KilogramForceMillimetersPerMillimeterInOneNewtonMeterPerMeterTest()
        {
            double expected = KilogramsForceInOneNewton;
            Assert.Equal(expected, KilogramForceMillimetersPerMillimeterInOneNewtonMeterPerMeter, 6);
        }

        [Fact]
        public void KilonewtonCentimetersPerCentimeterInOneNewtonMeterPerMeterTest()
        {
            double expected = KilonewtonsInOneNewton;
            Assert.Equal(expected, KilonewtonCentimetersPerCentimeterInOneNewtonMeterPerMeter, 6);
        }

        [Fact]
        public void KilonewtonMetersPerCentimeterInOneNewtonMeterPerMeterTest()
        {
            double expected = KilonewtonsInOneNewton / 100.0;
            Assert.Equal(expected, KilonewtonMetersPerCentimeterInOneNewtonMeterPerMeter, 6);
        }

        [Fact]
        public void KilonewtonMetersPerMeterInOneNewtonMeterPerMeterTest()
        {
            double expected = KilonewtonsInOneNewton;
            Assert.Equal(expected, KilonewtonMetersPerMeterInOneNewtonMeterPerMeter, 6);
        }

        [Fact]
        public void KilonewtonMetersPerMillimeterInOneNewtonMeterPerMeterTest()
        {
            double expected = KilonewtonsInOneNewton / 1000.0;
            Assert.Equal(expected, KilonewtonMetersPerMillimeterInOneNewtonMeterPerMeter, 6);
        }

        [Fact]
        public void KilonewtonMillimetersPerMillimeterInOneNewtonMeterPerMeterTest()
        {
            double expected = KilonewtonsInOneNewton;
            Assert.Equal(expected, KilonewtonMillimetersPerMillimeterInOneNewtonMeterPerMeter, 6);
        }

        [Fact]
        public void KilopoundForceFeetPerFootInOneNewtonMeterPerMeterTest()
        {
            double expected = KilopoundsForceInOneNewton;
            Assert.Equal(expected, KilopoundForceFeetPerFootInOneNewtonMeterPerMeter, 6);
        }

        [Fact]
        public void KilopoundForceFeetPerInchInOneNewtonMeterPerMeterTest()
        {
            double expected = KilopoundsForceInOneNewton * FeetInOneMeter / InchesInOneMeter;
            Assert.Equal(expected, KilopoundForceFeetPerInchInOneNewtonMeterPerMeter, 6);
        }

        [Fact]
        public void KilopoundForceInchesPerInchInOneNewtonMeterPerMeterTest()
        {
            double expected = KilopoundsForceInOneNewton;
            Assert.Equal(expected, KilopoundForceInchesPerInchInOneNewtonMeterPerMeter, 6);
        }

        [Fact]
        public void MeganewtonCentimetersPerCentimeterInOneNewtonMeterPerMeterTest()
        {
            double expected = MeganewtonsInOneNewton;
            Assert.Equal(expected, MeganewtonCentimetersPerCentimeterInOneNewtonMeterPerMeter, 6);
        }

        [Fact]
        public void MeganewtonMetersPerCentimeterInOneNewtonMeterPerMeterTest()
        {
            double expected = MeganewtonsInOneNewton / 100.0;
            Assert.Equal(expected, MeganewtonMetersPerCentimeterInOneNewtonMeterPerMeter, 6);
        }

        [Fact]
        public void MeganewtonMetersPerMeterInOneNewtonMeterPerMeterTest()
        {
            double expected = MeganewtonsInOneNewton;
            Assert.Equal(expected, MeganewtonMetersPerMeterInOneNewtonMeterPerMeter, 6);
        }

        [Fact]
        public void MeganewtonMetersPerMillimeterInOneNewtonMeterPerMeterTest()
        {
            double expected = MeganewtonsInOneNewton / 1000.0;
            Assert.Equal(expected, MeganewtonMetersPerMillimeterInOneNewtonMeterPerMeter, 6);
        }

        [Fact]
        public void MeganewtonMillimetersPerMillimeterInOneNewtonMeterPerMeterTest()
        {
            double expected = MeganewtonsInOneNewton;
            Assert.Equal(expected, MeganewtonMillimetersPerMillimeterInOneNewtonMeterPerMeter, 6);
        }

        [Fact]
        public void NewtonCentimetersPerCentimeterInOneNewtonMeterPerMeterTest()
        {
            double expected = NewtonsInOneNewton;
            Assert.Equal(expected, NewtonCentimetersPerCentimeterInOneNewtonMeterPerMeter, 6);
        }

        [Fact]
        public void NewtonMetersPerCentimeterInOneNewtonMeterPerMeterTest()
        {
            double expected = NewtonsInOneNewton / 100.0;
            Assert.Equal(expected, NewtonMetersPerCentimeterInOneNewtonMeterPerMeter, 6);
        }

        [Fact]
        public void NewtonMetersPerMeterInOneNewtonMeterPerMeterTest()
        {
            double expected = NewtonsInOneNewton;
            Assert.Equal(expected, NewtonMetersPerMeterInOneNewtonMeterPerMeter, 6);
        }

        [Fact]
        public void NewtonMetersPerMillimeterInOneNewtonMeterPerMeterTest()
        {
            double expected = NewtonsInOneNewton / 1000.0;
            Assert.Equal(expected, NewtonMetersPerMillimeterInOneNewtonMeterPerMeter, 6);
        }

        [Fact]
        public void NewtonMillimetersPerMillimeterInOneNewtonMeterPerMeterTest()
        {
            double expected = NewtonsInOneNewton;
            Assert.Equal(expected, NewtonMillimetersPerMillimeterInOneNewtonMeterPerMeter, 6);
        }

        [Fact]
        public void PoundForceFeetPerFootInOneNewtonMeterPerMeterTest()
        {
            double expected = PoundsForceInOneNewton;
            Assert.Equal(expected, PoundForceFeetPerFootInOneNewtonMeterPerMeter, 6);
        }

        [Fact]
        public void PoundForceFeetPerInchInOneNewtonMeterPerMeterTest()
        {
            double expected = FeetInOneMeter / InchesInOneMeter * PoundsForceInOneNewton;
            Assert.Equal(expected, PoundForceFeetPerInchInOneNewtonMeterPerMeter, 6);
        }

        [Fact]
        public void PoundForceFeetPerYardInOneNewtonMeterPerMeterTest()
        {
            double expected = FeetInOneMeter / YardsInOneMeter * PoundsForceInOneNewton;
            Assert.Equal(expected, PoundForceFeetPerYardInOneNewtonMeterPerMeter, 5);
        }

        [Fact]
        public void PoundForceInchesPerInchInOneNewtonMeterPerMeterTest()
        {
            double expected = PoundsForceInOneNewton;
            Assert.Equal(expected, PoundForceInchesPerInchInOneNewtonMeterPerMeter, 6);
        }

        [Fact]
        public void TonneForceCentimetersPerCentimeterInOneNewtonMeterPerMeterTest()
        {
            double expected = TonnesForceInOneNewton;
            Assert.Equal(expected, TonneForceCentimetersPerCentimeterInOneNewtonMeterPerMeter, 6);
        }

        [Fact]
        public void TonneForceMetersPerCentimeterInOneNewtonMeterPerMeterTest()
        {
            double expected = TonnesForceInOneNewton / 100.0;
            Assert.Equal(expected, TonneForceMetersPerCentimeterInOneNewtonMeterPerMeter, 6);
        }

        [Fact]
        public void TonneForceMetersPerMeterInOneNewtonMeterPerMeterTest()
        {
            double expected = TonnesForceInOneNewton;
            Assert.Equal(expected, TonneForceMetersPerMeterInOneNewtonMeterPerMeter, 6);
        }

        [Fact]
        public void TonneForceMetersPerMillimeterInOneNewtonMeterPerMeterTest()
        {
            double expected = TonnesForceInOneNewton / 1000.0;
            Assert.Equal(expected, TonneForceMetersPerMillimeterInOneNewtonMeterPerMeter, 6);
        }

        [Fact]
        public void TonneForceMillimetersPerMillimeterInOneNewtonMeterPerMeterTest()
        {
            double expected = TonnesForceInOneNewton;
            Assert.Equal(expected, TonneForceMillimetersPerMillimeterInOneNewtonMeterPerMeter, 6);
        }
    }
}
