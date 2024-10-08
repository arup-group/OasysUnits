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

namespace OasysUnits.NumberExtensions.NumberToMassConcentration
{
    /// <summary>
    /// A number to MassConcentration Extensions
    /// </summary>
    public static class NumberToMassConcentrationExtensions
    {
        /// <inheritdoc cref="MassConcentration.FromCentigramsPerDeciliter(double)" />
        public static MassConcentration CentigramsPerDeciliter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => MassConcentration.FromCentigramsPerDeciliter(Convert.ToDouble(value));

        /// <inheritdoc cref="MassConcentration.FromCentigramsPerLiter(double)" />
        public static MassConcentration CentigramsPerLiter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => MassConcentration.FromCentigramsPerLiter(Convert.ToDouble(value));

        /// <inheritdoc cref="MassConcentration.FromCentigramsPerMicroliter(double)" />
        public static MassConcentration CentigramsPerMicroliter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => MassConcentration.FromCentigramsPerMicroliter(Convert.ToDouble(value));

        /// <inheritdoc cref="MassConcentration.FromCentigramsPerMilliliter(double)" />
        public static MassConcentration CentigramsPerMilliliter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => MassConcentration.FromCentigramsPerMilliliter(Convert.ToDouble(value));

        /// <inheritdoc cref="MassConcentration.FromDecigramsPerDeciliter(double)" />
        public static MassConcentration DecigramsPerDeciliter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => MassConcentration.FromDecigramsPerDeciliter(Convert.ToDouble(value));

        /// <inheritdoc cref="MassConcentration.FromDecigramsPerLiter(double)" />
        public static MassConcentration DecigramsPerLiter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => MassConcentration.FromDecigramsPerLiter(Convert.ToDouble(value));

        /// <inheritdoc cref="MassConcentration.FromDecigramsPerMicroliter(double)" />
        public static MassConcentration DecigramsPerMicroliter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => MassConcentration.FromDecigramsPerMicroliter(Convert.ToDouble(value));

        /// <inheritdoc cref="MassConcentration.FromDecigramsPerMilliliter(double)" />
        public static MassConcentration DecigramsPerMilliliter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => MassConcentration.FromDecigramsPerMilliliter(Convert.ToDouble(value));

        /// <inheritdoc cref="MassConcentration.FromGramsPerCubicCentimeter(double)" />
        public static MassConcentration GramsPerCubicCentimeter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => MassConcentration.FromGramsPerCubicCentimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="MassConcentration.FromGramsPerCubicMeter(double)" />
        public static MassConcentration GramsPerCubicMeter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => MassConcentration.FromGramsPerCubicMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="MassConcentration.FromGramsPerCubicMillimeter(double)" />
        public static MassConcentration GramsPerCubicMillimeter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => MassConcentration.FromGramsPerCubicMillimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="MassConcentration.FromGramsPerDeciliter(double)" />
        public static MassConcentration GramsPerDeciliter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => MassConcentration.FromGramsPerDeciliter(Convert.ToDouble(value));

        /// <inheritdoc cref="MassConcentration.FromGramsPerLiter(double)" />
        public static MassConcentration GramsPerLiter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => MassConcentration.FromGramsPerLiter(Convert.ToDouble(value));

        /// <inheritdoc cref="MassConcentration.FromGramsPerMicroliter(double)" />
        public static MassConcentration GramsPerMicroliter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => MassConcentration.FromGramsPerMicroliter(Convert.ToDouble(value));

        /// <inheritdoc cref="MassConcentration.FromGramsPerMilliliter(double)" />
        public static MassConcentration GramsPerMilliliter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => MassConcentration.FromGramsPerMilliliter(Convert.ToDouble(value));

        /// <inheritdoc cref="MassConcentration.FromKilogramsPerCubicCentimeter(double)" />
        public static MassConcentration KilogramsPerCubicCentimeter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => MassConcentration.FromKilogramsPerCubicCentimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="MassConcentration.FromKilogramsPerCubicMeter(double)" />
        public static MassConcentration KilogramsPerCubicMeter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => MassConcentration.FromKilogramsPerCubicMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="MassConcentration.FromKilogramsPerCubicMillimeter(double)" />
        public static MassConcentration KilogramsPerCubicMillimeter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => MassConcentration.FromKilogramsPerCubicMillimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="MassConcentration.FromKilogramsPerLiter(double)" />
        public static MassConcentration KilogramsPerLiter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => MassConcentration.FromKilogramsPerLiter(Convert.ToDouble(value));

        /// <inheritdoc cref="MassConcentration.FromKilopoundsPerCubicFoot(double)" />
        public static MassConcentration KilopoundsPerCubicFoot<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => MassConcentration.FromKilopoundsPerCubicFoot(Convert.ToDouble(value));

        /// <inheritdoc cref="MassConcentration.FromKilopoundsPerCubicInch(double)" />
        public static MassConcentration KilopoundsPerCubicInch<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => MassConcentration.FromKilopoundsPerCubicInch(Convert.ToDouble(value));

        /// <inheritdoc cref="MassConcentration.FromMicrogramsPerCubicMeter(double)" />
        public static MassConcentration MicrogramsPerCubicMeter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => MassConcentration.FromMicrogramsPerCubicMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="MassConcentration.FromMicrogramsPerDeciliter(double)" />
        public static MassConcentration MicrogramsPerDeciliter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => MassConcentration.FromMicrogramsPerDeciliter(Convert.ToDouble(value));

        /// <inheritdoc cref="MassConcentration.FromMicrogramsPerLiter(double)" />
        public static MassConcentration MicrogramsPerLiter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => MassConcentration.FromMicrogramsPerLiter(Convert.ToDouble(value));

        /// <inheritdoc cref="MassConcentration.FromMicrogramsPerMicroliter(double)" />
        public static MassConcentration MicrogramsPerMicroliter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => MassConcentration.FromMicrogramsPerMicroliter(Convert.ToDouble(value));

        /// <inheritdoc cref="MassConcentration.FromMicrogramsPerMilliliter(double)" />
        public static MassConcentration MicrogramsPerMilliliter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => MassConcentration.FromMicrogramsPerMilliliter(Convert.ToDouble(value));

        /// <inheritdoc cref="MassConcentration.FromMilligramsPerCubicMeter(double)" />
        public static MassConcentration MilligramsPerCubicMeter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => MassConcentration.FromMilligramsPerCubicMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="MassConcentration.FromMilligramsPerDeciliter(double)" />
        public static MassConcentration MilligramsPerDeciliter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => MassConcentration.FromMilligramsPerDeciliter(Convert.ToDouble(value));

        /// <inheritdoc cref="MassConcentration.FromMilligramsPerLiter(double)" />
        public static MassConcentration MilligramsPerLiter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => MassConcentration.FromMilligramsPerLiter(Convert.ToDouble(value));

        /// <inheritdoc cref="MassConcentration.FromMilligramsPerMicroliter(double)" />
        public static MassConcentration MilligramsPerMicroliter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => MassConcentration.FromMilligramsPerMicroliter(Convert.ToDouble(value));

        /// <inheritdoc cref="MassConcentration.FromMilligramsPerMilliliter(double)" />
        public static MassConcentration MilligramsPerMilliliter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => MassConcentration.FromMilligramsPerMilliliter(Convert.ToDouble(value));

        /// <inheritdoc cref="MassConcentration.FromNanogramsPerDeciliter(double)" />
        public static MassConcentration NanogramsPerDeciliter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => MassConcentration.FromNanogramsPerDeciliter(Convert.ToDouble(value));

        /// <inheritdoc cref="MassConcentration.FromNanogramsPerLiter(double)" />
        public static MassConcentration NanogramsPerLiter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => MassConcentration.FromNanogramsPerLiter(Convert.ToDouble(value));

        /// <inheritdoc cref="MassConcentration.FromNanogramsPerMicroliter(double)" />
        public static MassConcentration NanogramsPerMicroliter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => MassConcentration.FromNanogramsPerMicroliter(Convert.ToDouble(value));

        /// <inheritdoc cref="MassConcentration.FromNanogramsPerMilliliter(double)" />
        public static MassConcentration NanogramsPerMilliliter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => MassConcentration.FromNanogramsPerMilliliter(Convert.ToDouble(value));

        /// <inheritdoc cref="MassConcentration.FromOuncesPerImperialGallon(double)" />
        public static MassConcentration OuncesPerImperialGallon<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => MassConcentration.FromOuncesPerImperialGallon(Convert.ToDouble(value));

        /// <inheritdoc cref="MassConcentration.FromOuncesPerUSGallon(double)" />
        public static MassConcentration OuncesPerUSGallon<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => MassConcentration.FromOuncesPerUSGallon(Convert.ToDouble(value));

        /// <inheritdoc cref="MassConcentration.FromPicogramsPerDeciliter(double)" />
        public static MassConcentration PicogramsPerDeciliter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => MassConcentration.FromPicogramsPerDeciliter(Convert.ToDouble(value));

        /// <inheritdoc cref="MassConcentration.FromPicogramsPerLiter(double)" />
        public static MassConcentration PicogramsPerLiter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => MassConcentration.FromPicogramsPerLiter(Convert.ToDouble(value));

        /// <inheritdoc cref="MassConcentration.FromPicogramsPerMicroliter(double)" />
        public static MassConcentration PicogramsPerMicroliter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => MassConcentration.FromPicogramsPerMicroliter(Convert.ToDouble(value));

        /// <inheritdoc cref="MassConcentration.FromPicogramsPerMilliliter(double)" />
        public static MassConcentration PicogramsPerMilliliter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => MassConcentration.FromPicogramsPerMilliliter(Convert.ToDouble(value));

        /// <inheritdoc cref="MassConcentration.FromPoundsPerCubicFoot(double)" />
        public static MassConcentration PoundsPerCubicFoot<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => MassConcentration.FromPoundsPerCubicFoot(Convert.ToDouble(value));

        /// <inheritdoc cref="MassConcentration.FromPoundsPerCubicInch(double)" />
        public static MassConcentration PoundsPerCubicInch<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => MassConcentration.FromPoundsPerCubicInch(Convert.ToDouble(value));

        /// <inheritdoc cref="MassConcentration.FromPoundsPerImperialGallon(double)" />
        public static MassConcentration PoundsPerImperialGallon<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => MassConcentration.FromPoundsPerImperialGallon(Convert.ToDouble(value));

        /// <inheritdoc cref="MassConcentration.FromPoundsPerUSGallon(double)" />
        public static MassConcentration PoundsPerUSGallon<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => MassConcentration.FromPoundsPerUSGallon(Convert.ToDouble(value));

        /// <inheritdoc cref="MassConcentration.FromSlugsPerCubicFoot(double)" />
        public static MassConcentration SlugsPerCubicFoot<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => MassConcentration.FromSlugsPerCubicFoot(Convert.ToDouble(value));

        /// <inheritdoc cref="MassConcentration.FromTonnesPerCubicCentimeter(double)" />
        public static MassConcentration TonnesPerCubicCentimeter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => MassConcentration.FromTonnesPerCubicCentimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="MassConcentration.FromTonnesPerCubicMeter(double)" />
        public static MassConcentration TonnesPerCubicMeter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => MassConcentration.FromTonnesPerCubicMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="MassConcentration.FromTonnesPerCubicMillimeter(double)" />
        public static MassConcentration TonnesPerCubicMillimeter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => MassConcentration.FromTonnesPerCubicMillimeter(Convert.ToDouble(value));

    }
}
