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

namespace OasysUnits.NumberExtensions.NumberToMassFraction
{
    /// <summary>
    /// A number to MassFraction Extensions
    /// </summary>
    public static class NumberToMassFractionExtensions
    {
        /// <inheritdoc cref="MassFraction.FromCentigramsPerGram(double)" />
        public static MassFraction CentigramsPerGram<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => MassFraction.FromCentigramsPerGram(Convert.ToDouble(value));

        /// <inheritdoc cref="MassFraction.FromCentigramsPerKilogram(double)" />
        public static MassFraction CentigramsPerKilogram<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => MassFraction.FromCentigramsPerKilogram(Convert.ToDouble(value));

        /// <inheritdoc cref="MassFraction.FromDecagramsPerGram(double)" />
        public static MassFraction DecagramsPerGram<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => MassFraction.FromDecagramsPerGram(Convert.ToDouble(value));

        /// <inheritdoc cref="MassFraction.FromDecagramsPerKilogram(double)" />
        public static MassFraction DecagramsPerKilogram<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => MassFraction.FromDecagramsPerKilogram(Convert.ToDouble(value));

        /// <inheritdoc cref="MassFraction.FromDecigramsPerGram(double)" />
        public static MassFraction DecigramsPerGram<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => MassFraction.FromDecigramsPerGram(Convert.ToDouble(value));

        /// <inheritdoc cref="MassFraction.FromDecigramsPerKilogram(double)" />
        public static MassFraction DecigramsPerKilogram<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => MassFraction.FromDecigramsPerKilogram(Convert.ToDouble(value));

        /// <inheritdoc cref="MassFraction.FromDecimalFractions(double)" />
        public static MassFraction DecimalFractions<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => MassFraction.FromDecimalFractions(Convert.ToDouble(value));

        /// <inheritdoc cref="MassFraction.FromGramsPerGram(double)" />
        public static MassFraction GramsPerGram<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => MassFraction.FromGramsPerGram(Convert.ToDouble(value));

        /// <inheritdoc cref="MassFraction.FromGramsPerKilogram(double)" />
        public static MassFraction GramsPerKilogram<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => MassFraction.FromGramsPerKilogram(Convert.ToDouble(value));

        /// <inheritdoc cref="MassFraction.FromHectogramsPerGram(double)" />
        public static MassFraction HectogramsPerGram<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => MassFraction.FromHectogramsPerGram(Convert.ToDouble(value));

        /// <inheritdoc cref="MassFraction.FromHectogramsPerKilogram(double)" />
        public static MassFraction HectogramsPerKilogram<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => MassFraction.FromHectogramsPerKilogram(Convert.ToDouble(value));

        /// <inheritdoc cref="MassFraction.FromKilogramsPerGram(double)" />
        public static MassFraction KilogramsPerGram<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => MassFraction.FromKilogramsPerGram(Convert.ToDouble(value));

        /// <inheritdoc cref="MassFraction.FromKilogramsPerKilogram(double)" />
        public static MassFraction KilogramsPerKilogram<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => MassFraction.FromKilogramsPerKilogram(Convert.ToDouble(value));

        /// <inheritdoc cref="MassFraction.FromMicrogramsPerGram(double)" />
        public static MassFraction MicrogramsPerGram<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => MassFraction.FromMicrogramsPerGram(Convert.ToDouble(value));

        /// <inheritdoc cref="MassFraction.FromMicrogramsPerKilogram(double)" />
        public static MassFraction MicrogramsPerKilogram<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => MassFraction.FromMicrogramsPerKilogram(Convert.ToDouble(value));

        /// <inheritdoc cref="MassFraction.FromMilligramsPerGram(double)" />
        public static MassFraction MilligramsPerGram<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => MassFraction.FromMilligramsPerGram(Convert.ToDouble(value));

        /// <inheritdoc cref="MassFraction.FromMilligramsPerKilogram(double)" />
        public static MassFraction MilligramsPerKilogram<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => MassFraction.FromMilligramsPerKilogram(Convert.ToDouble(value));

        /// <inheritdoc cref="MassFraction.FromNanogramsPerGram(double)" />
        public static MassFraction NanogramsPerGram<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => MassFraction.FromNanogramsPerGram(Convert.ToDouble(value));

        /// <inheritdoc cref="MassFraction.FromNanogramsPerKilogram(double)" />
        public static MassFraction NanogramsPerKilogram<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => MassFraction.FromNanogramsPerKilogram(Convert.ToDouble(value));

        /// <inheritdoc cref="MassFraction.FromPartsPerBillion(double)" />
        public static MassFraction PartsPerBillion<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => MassFraction.FromPartsPerBillion(Convert.ToDouble(value));

        /// <inheritdoc cref="MassFraction.FromPartsPerMillion(double)" />
        public static MassFraction PartsPerMillion<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => MassFraction.FromPartsPerMillion(Convert.ToDouble(value));

        /// <inheritdoc cref="MassFraction.FromPartsPerThousand(double)" />
        public static MassFraction PartsPerThousand<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => MassFraction.FromPartsPerThousand(Convert.ToDouble(value));

        /// <inheritdoc cref="MassFraction.FromPartsPerTrillion(double)" />
        public static MassFraction PartsPerTrillion<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => MassFraction.FromPartsPerTrillion(Convert.ToDouble(value));

        /// <inheritdoc cref="MassFraction.FromPercent(double)" />
        public static MassFraction Percent<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => MassFraction.FromPercent(Convert.ToDouble(value));

    }
}
