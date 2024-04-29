﻿// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;

namespace OasysUnits
{
    public partial struct Pressure
    {
        /// <summary>Get <see cref="Force"/> from <see cref="Pressure"/> times <see cref="Area"/>.</summary>
        public static Force operator *(Pressure pressure, Area area)
        {
            return Force.FromNewtons(pressure.Pascals * area.SquareMeters);
        }

        /// <summary>Get <see cref="Force"/> from <see cref="Area"/> times <see cref="Pressure"/>.</summary>
        public static Force operator *(Area area, Pressure pressure)
        {
            return Force.FromNewtons(pressure.Pascals * area.SquareMeters);
        }

        /// <summary>Get <see cref="Length"/> from <see cref="Pressure"/> divided by <see cref="SpecificWeight"/>.</summary>
        public static Length operator /(Pressure pressure, SpecificWeight specificWeight)
        {
            return new Length(pressure.Pascals / specificWeight.NewtonsPerCubicMeter, OasysUnits.Units.LengthUnit.Meter);
        }

        /// <summary>Get <see cref="SpecificWeight"/> from <see cref="Pressure"/> divided by <see cref="Length"/>.</summary>
        public static SpecificWeight operator /(Pressure pressure, Length length)
        {
            return new SpecificWeight(pressure.Pascals / length.Meters, OasysUnits.Units.SpecificWeightUnit.NewtonPerCubicMeter);
        }

        /// <summary>Get <see cref="ForcePerLength"/> from <see cref="Pressure"/> divided by <see cref="ReciprocalLength"/>.</summary>
        public static ForcePerLength operator /(Pressure pressure, ReciprocalLength reciprocalLength)
        {
            return new ForcePerLength(pressure.Pascals / reciprocalLength.InverseMeters, OasysUnits.Units.ForcePerLengthUnit.NewtonPerMeter);
        }

        /// <summary>Get <see cref="Force"/> from <see cref="Pressure"/> divided by <see cref="ReciprocalArea"/>.</summary>
        public static Force operator /(Pressure pressure, ReciprocalArea reciprocalArea)
        {
            return new Force(pressure.Pascals / reciprocalArea.InverseSquareMeters, OasysUnits.Units.ForceUnit.Newton);
        }

        /// <summary>Get <see cref="PressureChangeRate"/> from <see cref="Pressure"/> divided by <see cref="TimeSpan"/> </summary>
        public static PressureChangeRate operator /(Pressure pressure, TimeSpan timeSpan)
        {
            return new PressureChangeRate(pressure.Pascals / timeSpan.TotalSeconds , OasysUnits.Units.PressureChangeRateUnit.PascalPerSecond);
        }

        /// <summary>Get <see cref="PressureChangeRate"/> from <see cref="Pressure"/> divided by <see cref="Duration"/> </summary>
        public static PressureChangeRate operator /(Pressure pressure, Duration duration)
        {
            return new PressureChangeRate(pressure.Pascals / duration.Seconds, OasysUnits.Units.PressureChangeRateUnit.PascalPerSecond);
        }
    }
}
