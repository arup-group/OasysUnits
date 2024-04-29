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

namespace OasysUnits.NumberExtensions.NumberToTemperature
{
    /// <summary>
    /// A number to Temperature Extensions
    /// </summary>
    public static class NumberToTemperatureExtensions
    {
        /// <inheritdoc cref="Temperature.FromDegreesCelsius(OasysUnits.QuantityValue)" />
        public static Temperature DegreesCelsius<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Temperature.FromDegreesCelsius(Convert.ToDouble(value));

        /// <inheritdoc cref="Temperature.FromDegreesDelisle(OasysUnits.QuantityValue)" />
        public static Temperature DegreesDelisle<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Temperature.FromDegreesDelisle(Convert.ToDouble(value));

        /// <inheritdoc cref="Temperature.FromDegreesFahrenheit(OasysUnits.QuantityValue)" />
        public static Temperature DegreesFahrenheit<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Temperature.FromDegreesFahrenheit(Convert.ToDouble(value));

        /// <inheritdoc cref="Temperature.FromDegreesNewton(OasysUnits.QuantityValue)" />
        public static Temperature DegreesNewton<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Temperature.FromDegreesNewton(Convert.ToDouble(value));

        /// <inheritdoc cref="Temperature.FromDegreesRankine(OasysUnits.QuantityValue)" />
        public static Temperature DegreesRankine<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Temperature.FromDegreesRankine(Convert.ToDouble(value));

        /// <inheritdoc cref="Temperature.FromDegreesReaumur(OasysUnits.QuantityValue)" />
        public static Temperature DegreesReaumur<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Temperature.FromDegreesReaumur(Convert.ToDouble(value));

        /// <inheritdoc cref="Temperature.FromDegreesRoemer(OasysUnits.QuantityValue)" />
        public static Temperature DegreesRoemer<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Temperature.FromDegreesRoemer(Convert.ToDouble(value));

        /// <inheritdoc cref="Temperature.FromKelvins(OasysUnits.QuantityValue)" />
        public static Temperature Kelvins<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Temperature.FromKelvins(Convert.ToDouble(value));

        /// <inheritdoc cref="Temperature.FromMillidegreesCelsius(OasysUnits.QuantityValue)" />
        public static Temperature MillidegreesCelsius<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Temperature.FromMillidegreesCelsius(Convert.ToDouble(value));

        /// <inheritdoc cref="Temperature.FromSolarTemperatures(OasysUnits.QuantityValue)" />
        public static Temperature SolarTemperatures<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Temperature.FromSolarTemperatures(Convert.ToDouble(value));

    }
}
