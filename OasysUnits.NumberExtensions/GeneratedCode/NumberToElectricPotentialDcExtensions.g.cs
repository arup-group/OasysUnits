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

namespace OasysUnits.NumberExtensions.NumberToElectricPotentialDc
{
    /// <summary>
    /// A number to ElectricPotentialDc Extensions
    /// </summary>
    public static class NumberToElectricPotentialDcExtensions
    {
        /// <inheritdoc cref="ElectricPotentialDc.FromKilovoltsDc(double)" />
        public static ElectricPotentialDc KilovoltsDc<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ElectricPotentialDc.FromKilovoltsDc(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricPotentialDc.FromMegavoltsDc(double)" />
        public static ElectricPotentialDc MegavoltsDc<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ElectricPotentialDc.FromMegavoltsDc(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricPotentialDc.FromMicrovoltsDc(double)" />
        public static ElectricPotentialDc MicrovoltsDc<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ElectricPotentialDc.FromMicrovoltsDc(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricPotentialDc.FromMillivoltsDc(double)" />
        public static ElectricPotentialDc MillivoltsDc<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ElectricPotentialDc.FromMillivoltsDc(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricPotentialDc.FromVoltsDc(double)" />
        public static ElectricPotentialDc VoltsDc<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ElectricPotentialDc.FromVoltsDc(Convert.ToDouble(value));

    }
}
