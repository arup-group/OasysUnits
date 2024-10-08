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

namespace OasysUnits.NumberExtensions.NumberToElectricCharge
{
    /// <summary>
    /// A number to ElectricCharge Extensions
    /// </summary>
    public static class NumberToElectricChargeExtensions
    {
        /// <inheritdoc cref="ElectricCharge.FromAmpereHours(double)" />
        public static ElectricCharge AmpereHours<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ElectricCharge.FromAmpereHours(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricCharge.FromCoulombs(double)" />
        public static ElectricCharge Coulombs<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ElectricCharge.FromCoulombs(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricCharge.FromKiloampereHours(double)" />
        public static ElectricCharge KiloampereHours<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ElectricCharge.FromKiloampereHours(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricCharge.FromKilocoulombs(double)" />
        public static ElectricCharge Kilocoulombs<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ElectricCharge.FromKilocoulombs(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricCharge.FromMegaampereHours(double)" />
        public static ElectricCharge MegaampereHours<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ElectricCharge.FromMegaampereHours(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricCharge.FromMegacoulombs(double)" />
        public static ElectricCharge Megacoulombs<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ElectricCharge.FromMegacoulombs(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricCharge.FromMicrocoulombs(double)" />
        public static ElectricCharge Microcoulombs<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ElectricCharge.FromMicrocoulombs(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricCharge.FromMilliampereHours(double)" />
        public static ElectricCharge MilliampereHours<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ElectricCharge.FromMilliampereHours(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricCharge.FromMillicoulombs(double)" />
        public static ElectricCharge Millicoulombs<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ElectricCharge.FromMillicoulombs(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricCharge.FromNanocoulombs(double)" />
        public static ElectricCharge Nanocoulombs<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ElectricCharge.FromNanocoulombs(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricCharge.FromPicocoulombs(double)" />
        public static ElectricCharge Picocoulombs<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ElectricCharge.FromPicocoulombs(Convert.ToDouble(value));

    }
}
