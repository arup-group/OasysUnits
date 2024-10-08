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

namespace OasysUnits.NumberExtensions.NumberToElectricConductivity
{
    /// <summary>
    /// A number to ElectricConductivity Extensions
    /// </summary>
    public static class NumberToElectricConductivityExtensions
    {
        /// <inheritdoc cref="ElectricConductivity.FromMicrosiemensPerCentimeter(double)" />
        public static ElectricConductivity MicrosiemensPerCentimeter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ElectricConductivity.FromMicrosiemensPerCentimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricConductivity.FromMillisiemensPerCentimeter(double)" />
        public static ElectricConductivity MillisiemensPerCentimeter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ElectricConductivity.FromMillisiemensPerCentimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricConductivity.FromSiemensPerCentimeter(double)" />
        public static ElectricConductivity SiemensPerCentimeter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ElectricConductivity.FromSiemensPerCentimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricConductivity.FromSiemensPerFoot(double)" />
        public static ElectricConductivity SiemensPerFoot<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ElectricConductivity.FromSiemensPerFoot(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricConductivity.FromSiemensPerInch(double)" />
        public static ElectricConductivity SiemensPerInch<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ElectricConductivity.FromSiemensPerInch(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricConductivity.FromSiemensPerMeter(double)" />
        public static ElectricConductivity SiemensPerMeter<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ElectricConductivity.FromSiemensPerMeter(Convert.ToDouble(value));

    }
}
