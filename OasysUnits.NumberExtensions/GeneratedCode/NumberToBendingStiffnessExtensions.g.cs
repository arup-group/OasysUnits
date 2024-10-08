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

using System;

#if NET7_0_OR_GREATER
using System.Numerics;
#endif

#nullable enable

namespace OasysUnits.NumberExtensions.NumberToBendingStiffness
{
    /// <summary>
    /// A number to BendingStiffness Extensions
    /// </summary>
    public static class NumberToBendingStiffnessExtensions
    {
        /// <inheritdoc cref="BendingStiffness.FromKilonewtonSquareMeters(double)" />
        public static BendingStiffness KilonewtonSquareMeters<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => BendingStiffness.FromKilonewtonSquareMeters(Convert.ToDouble(value));

        /// <inheritdoc cref="BendingStiffness.FromKilonewtonSquareMillimeters(double)" />
        public static BendingStiffness KilonewtonSquareMillimeters<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => BendingStiffness.FromKilonewtonSquareMillimeters(Convert.ToDouble(value));

        /// <inheritdoc cref="BendingStiffness.FromNewtonSquareMeters(double)" />
        public static BendingStiffness NewtonSquareMeters<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => BendingStiffness.FromNewtonSquareMeters(Convert.ToDouble(value));

        /// <inheritdoc cref="BendingStiffness.FromNewtonSquareMillimeters(double)" />
        public static BendingStiffness NewtonSquareMillimeters<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => BendingStiffness.FromNewtonSquareMillimeters(Convert.ToDouble(value));

        /// <inheritdoc cref="BendingStiffness.FromPoundsForceSquareFeet(double)" />
        public static BendingStiffness PoundsForceSquareFeet<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => BendingStiffness.FromPoundsForceSquareFeet(Convert.ToDouble(value));

        /// <inheritdoc cref="BendingStiffness.FromPoundsForceSquareInches(double)" />
        public static BendingStiffness PoundsForceSquareInches<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => BendingStiffness.FromPoundsForceSquareInches(Convert.ToDouble(value));

    }
}
