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

namespace OasysUnits.NumberExtensions.NumberToReciprocalArea
{
    /// <summary>
    /// A number to ReciprocalArea Extensions
    /// </summary>
    public static class NumberToReciprocalAreaExtensions
    {
        /// <inheritdoc cref="ReciprocalArea.FromInverseSquareCentimeters(OasysUnits.QuantityValue)" />
        public static ReciprocalArea InverseSquareCentimeters<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ReciprocalArea.FromInverseSquareCentimeters(Convert.ToDouble(value));

        /// <inheritdoc cref="ReciprocalArea.FromInverseSquareDecimeters(OasysUnits.QuantityValue)" />
        public static ReciprocalArea InverseSquareDecimeters<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ReciprocalArea.FromInverseSquareDecimeters(Convert.ToDouble(value));

        /// <inheritdoc cref="ReciprocalArea.FromInverseSquareFeet(OasysUnits.QuantityValue)" />
        public static ReciprocalArea InverseSquareFeet<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ReciprocalArea.FromInverseSquareFeet(Convert.ToDouble(value));

        /// <inheritdoc cref="ReciprocalArea.FromInverseSquareInches(OasysUnits.QuantityValue)" />
        public static ReciprocalArea InverseSquareInches<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ReciprocalArea.FromInverseSquareInches(Convert.ToDouble(value));

        /// <inheritdoc cref="ReciprocalArea.FromInverseSquareKilometers(OasysUnits.QuantityValue)" />
        public static ReciprocalArea InverseSquareKilometers<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ReciprocalArea.FromInverseSquareKilometers(Convert.ToDouble(value));

        /// <inheritdoc cref="ReciprocalArea.FromInverseSquareMeters(OasysUnits.QuantityValue)" />
        public static ReciprocalArea InverseSquareMeters<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ReciprocalArea.FromInverseSquareMeters(Convert.ToDouble(value));

        /// <inheritdoc cref="ReciprocalArea.FromInverseSquareMicrometers(OasysUnits.QuantityValue)" />
        public static ReciprocalArea InverseSquareMicrometers<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ReciprocalArea.FromInverseSquareMicrometers(Convert.ToDouble(value));

        /// <inheritdoc cref="ReciprocalArea.FromInverseSquareMiles(OasysUnits.QuantityValue)" />
        public static ReciprocalArea InverseSquareMiles<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ReciprocalArea.FromInverseSquareMiles(Convert.ToDouble(value));

        /// <inheritdoc cref="ReciprocalArea.FromInverseSquareMillimeters(OasysUnits.QuantityValue)" />
        public static ReciprocalArea InverseSquareMillimeters<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ReciprocalArea.FromInverseSquareMillimeters(Convert.ToDouble(value));

        /// <inheritdoc cref="ReciprocalArea.FromInverseSquareYards(OasysUnits.QuantityValue)" />
        public static ReciprocalArea InverseSquareYards<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ReciprocalArea.FromInverseSquareYards(Convert.ToDouble(value));

        /// <inheritdoc cref="ReciprocalArea.FromInverseUsSurveySquareFeet(OasysUnits.QuantityValue)" />
        public static ReciprocalArea InverseUsSurveySquareFeet<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ReciprocalArea.FromInverseUsSurveySquareFeet(Convert.ToDouble(value));

    }
}
