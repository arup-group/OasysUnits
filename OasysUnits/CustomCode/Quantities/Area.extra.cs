﻿// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/OasysUnits.

using System;

namespace OasysUnits
{
    public partial struct Area
    {
        #region Static Methods

        /// <summary>Get circle area from a diameter.</summary>
        public static Area FromCircleDiameter(Length diameter)
        {
            var radius = Length.FromMeters(diameter.Meters / 2d);
            return FromCircleRadius(radius);
        }

        /// <summary>Get circle area from a radius.</summary>
        public static Area FromCircleRadius(Length radius)
        {
            return FromSquareMeters(Math.PI * radius.Meters * radius.Meters);
        }

        #endregion
    }
}
