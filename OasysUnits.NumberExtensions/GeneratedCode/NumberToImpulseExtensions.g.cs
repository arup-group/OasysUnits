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

namespace OasysUnits.NumberExtensions.NumberToImpulse
{
    /// <summary>
    /// A number to Impulse Extensions
    /// </summary>
    public static class NumberToImpulseExtensions
    {
        /// <inheritdoc cref="Impulse.FromCentinewtonSeconds(double)" />
        public static Impulse CentinewtonSeconds<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Impulse.FromCentinewtonSeconds(Convert.ToDouble(value));

        /// <inheritdoc cref="Impulse.FromDecanewtonSeconds(double)" />
        public static Impulse DecanewtonSeconds<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Impulse.FromDecanewtonSeconds(Convert.ToDouble(value));

        /// <inheritdoc cref="Impulse.FromDecinewtonSeconds(double)" />
        public static Impulse DecinewtonSeconds<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Impulse.FromDecinewtonSeconds(Convert.ToDouble(value));

        /// <inheritdoc cref="Impulse.FromKilogramMetersPerSecond(double)" />
        public static Impulse KilogramMetersPerSecond<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Impulse.FromKilogramMetersPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="Impulse.FromKilonewtonSeconds(double)" />
        public static Impulse KilonewtonSeconds<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Impulse.FromKilonewtonSeconds(Convert.ToDouble(value));

        /// <inheritdoc cref="Impulse.FromMeganewtonSeconds(double)" />
        public static Impulse MeganewtonSeconds<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Impulse.FromMeganewtonSeconds(Convert.ToDouble(value));

        /// <inheritdoc cref="Impulse.FromMicronewtonSeconds(double)" />
        public static Impulse MicronewtonSeconds<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Impulse.FromMicronewtonSeconds(Convert.ToDouble(value));

        /// <inheritdoc cref="Impulse.FromMillinewtonSeconds(double)" />
        public static Impulse MillinewtonSeconds<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Impulse.FromMillinewtonSeconds(Convert.ToDouble(value));

        /// <inheritdoc cref="Impulse.FromNanonewtonSeconds(double)" />
        public static Impulse NanonewtonSeconds<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Impulse.FromNanonewtonSeconds(Convert.ToDouble(value));

        /// <inheritdoc cref="Impulse.FromNewtonSeconds(double)" />
        public static Impulse NewtonSeconds<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Impulse.FromNewtonSeconds(Convert.ToDouble(value));

        /// <inheritdoc cref="Impulse.FromPoundFeetPerSecond(double)" />
        public static Impulse PoundFeetPerSecond<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Impulse.FromPoundFeetPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="Impulse.FromPoundForceSeconds(double)" />
        public static Impulse PoundForceSeconds<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Impulse.FromPoundForceSeconds(Convert.ToDouble(value));

        /// <inheritdoc cref="Impulse.FromSlugFeetPerSecond(double)" />
        public static Impulse SlugFeetPerSecond<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Impulse.FromSlugFeetPerSecond(Convert.ToDouble(value));

    }
}
