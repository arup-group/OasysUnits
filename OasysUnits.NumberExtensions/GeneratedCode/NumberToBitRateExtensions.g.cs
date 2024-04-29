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

namespace OasysUnits.NumberExtensions.NumberToBitRate
{
    /// <summary>
    /// A number to BitRate Extensions
    /// </summary>
    public static class NumberToBitRateExtensions
    {
        /// <inheritdoc cref="BitRate.FromBitsPerSecond(OasysUnits.QuantityValue)" />
        public static BitRate BitsPerSecond<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => BitRate.FromBitsPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="BitRate.FromBytesPerSecond(OasysUnits.QuantityValue)" />
        public static BitRate BytesPerSecond<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => BitRate.FromBytesPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="BitRate.FromExabitsPerSecond(OasysUnits.QuantityValue)" />
        public static BitRate ExabitsPerSecond<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => BitRate.FromExabitsPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="BitRate.FromExabytesPerSecond(OasysUnits.QuantityValue)" />
        public static BitRate ExabytesPerSecond<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => BitRate.FromExabytesPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="BitRate.FromExbibitsPerSecond(OasysUnits.QuantityValue)" />
        public static BitRate ExbibitsPerSecond<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => BitRate.FromExbibitsPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="BitRate.FromExbibytesPerSecond(OasysUnits.QuantityValue)" />
        public static BitRate ExbibytesPerSecond<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => BitRate.FromExbibytesPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="BitRate.FromGibibitsPerSecond(OasysUnits.QuantityValue)" />
        public static BitRate GibibitsPerSecond<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => BitRate.FromGibibitsPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="BitRate.FromGibibytesPerSecond(OasysUnits.QuantityValue)" />
        public static BitRate GibibytesPerSecond<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => BitRate.FromGibibytesPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="BitRate.FromGigabitsPerSecond(OasysUnits.QuantityValue)" />
        public static BitRate GigabitsPerSecond<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => BitRate.FromGigabitsPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="BitRate.FromGigabytesPerSecond(OasysUnits.QuantityValue)" />
        public static BitRate GigabytesPerSecond<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => BitRate.FromGigabytesPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="BitRate.FromKibibitsPerSecond(OasysUnits.QuantityValue)" />
        public static BitRate KibibitsPerSecond<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => BitRate.FromKibibitsPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="BitRate.FromKibibytesPerSecond(OasysUnits.QuantityValue)" />
        public static BitRate KibibytesPerSecond<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => BitRate.FromKibibytesPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="BitRate.FromKilobitsPerSecond(OasysUnits.QuantityValue)" />
        public static BitRate KilobitsPerSecond<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => BitRate.FromKilobitsPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="BitRate.FromKilobytesPerSecond(OasysUnits.QuantityValue)" />
        public static BitRate KilobytesPerSecond<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => BitRate.FromKilobytesPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="BitRate.FromMebibitsPerSecond(OasysUnits.QuantityValue)" />
        public static BitRate MebibitsPerSecond<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => BitRate.FromMebibitsPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="BitRate.FromMebibytesPerSecond(OasysUnits.QuantityValue)" />
        public static BitRate MebibytesPerSecond<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => BitRate.FromMebibytesPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="BitRate.FromMegabitsPerSecond(OasysUnits.QuantityValue)" />
        public static BitRate MegabitsPerSecond<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => BitRate.FromMegabitsPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="BitRate.FromMegabytesPerSecond(OasysUnits.QuantityValue)" />
        public static BitRate MegabytesPerSecond<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => BitRate.FromMegabytesPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="BitRate.FromPebibitsPerSecond(OasysUnits.QuantityValue)" />
        public static BitRate PebibitsPerSecond<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => BitRate.FromPebibitsPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="BitRate.FromPebibytesPerSecond(OasysUnits.QuantityValue)" />
        public static BitRate PebibytesPerSecond<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => BitRate.FromPebibytesPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="BitRate.FromPetabitsPerSecond(OasysUnits.QuantityValue)" />
        public static BitRate PetabitsPerSecond<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => BitRate.FromPetabitsPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="BitRate.FromPetabytesPerSecond(OasysUnits.QuantityValue)" />
        public static BitRate PetabytesPerSecond<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => BitRate.FromPetabytesPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="BitRate.FromTebibitsPerSecond(OasysUnits.QuantityValue)" />
        public static BitRate TebibitsPerSecond<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => BitRate.FromTebibitsPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="BitRate.FromTebibytesPerSecond(OasysUnits.QuantityValue)" />
        public static BitRate TebibytesPerSecond<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => BitRate.FromTebibytesPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="BitRate.FromTerabitsPerSecond(OasysUnits.QuantityValue)" />
        public static BitRate TerabitsPerSecond<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => BitRate.FromTerabitsPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="BitRate.FromTerabytesPerSecond(OasysUnits.QuantityValue)" />
        public static BitRate TerabytesPerSecond<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => BitRate.FromTerabytesPerSecond(Convert.ToDouble(value));

    }
}
