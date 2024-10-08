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

namespace OasysUnits.NumberExtensions.NumberToMolality
{
    /// <summary>
    /// A number to Molality Extensions
    /// </summary>
    public static class NumberToMolalityExtensions
    {
        /// <inheritdoc cref="Molality.FromMillimolesPerKilogram(double)" />
        public static Molality MillimolesPerKilogram<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Molality.FromMillimolesPerKilogram(Convert.ToDouble(value));

        /// <inheritdoc cref="Molality.FromMolesPerGram(double)" />
        public static Molality MolesPerGram<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Molality.FromMolesPerGram(Convert.ToDouble(value));

        /// <inheritdoc cref="Molality.FromMolesPerKilogram(double)" />
        public static Molality MolesPerKilogram<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Molality.FromMolesPerKilogram(Convert.ToDouble(value));

    }
}
