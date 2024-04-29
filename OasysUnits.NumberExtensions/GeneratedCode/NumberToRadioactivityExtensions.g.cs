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

namespace OasysUnits.NumberExtensions.NumberToRadioactivity
{
    /// <summary>
    /// A number to Radioactivity Extensions
    /// </summary>
    public static class NumberToRadioactivityExtensions
    {
        /// <inheritdoc cref="Radioactivity.FromBecquerels(OasysUnits.QuantityValue)" />
        public static Radioactivity Becquerels<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Radioactivity.FromBecquerels(Convert.ToDouble(value));

        /// <inheritdoc cref="Radioactivity.FromCuries(OasysUnits.QuantityValue)" />
        public static Radioactivity Curies<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Radioactivity.FromCuries(Convert.ToDouble(value));

        /// <inheritdoc cref="Radioactivity.FromExabecquerels(OasysUnits.QuantityValue)" />
        public static Radioactivity Exabecquerels<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Radioactivity.FromExabecquerels(Convert.ToDouble(value));

        /// <inheritdoc cref="Radioactivity.FromGigabecquerels(OasysUnits.QuantityValue)" />
        public static Radioactivity Gigabecquerels<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Radioactivity.FromGigabecquerels(Convert.ToDouble(value));

        /// <inheritdoc cref="Radioactivity.FromGigacuries(OasysUnits.QuantityValue)" />
        public static Radioactivity Gigacuries<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Radioactivity.FromGigacuries(Convert.ToDouble(value));

        /// <inheritdoc cref="Radioactivity.FromGigarutherfords(OasysUnits.QuantityValue)" />
        public static Radioactivity Gigarutherfords<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Radioactivity.FromGigarutherfords(Convert.ToDouble(value));

        /// <inheritdoc cref="Radioactivity.FromKilobecquerels(OasysUnits.QuantityValue)" />
        public static Radioactivity Kilobecquerels<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Radioactivity.FromKilobecquerels(Convert.ToDouble(value));

        /// <inheritdoc cref="Radioactivity.FromKilocuries(OasysUnits.QuantityValue)" />
        public static Radioactivity Kilocuries<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Radioactivity.FromKilocuries(Convert.ToDouble(value));

        /// <inheritdoc cref="Radioactivity.FromKilorutherfords(OasysUnits.QuantityValue)" />
        public static Radioactivity Kilorutherfords<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Radioactivity.FromKilorutherfords(Convert.ToDouble(value));

        /// <inheritdoc cref="Radioactivity.FromMegabecquerels(OasysUnits.QuantityValue)" />
        public static Radioactivity Megabecquerels<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Radioactivity.FromMegabecquerels(Convert.ToDouble(value));

        /// <inheritdoc cref="Radioactivity.FromMegacuries(OasysUnits.QuantityValue)" />
        public static Radioactivity Megacuries<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Radioactivity.FromMegacuries(Convert.ToDouble(value));

        /// <inheritdoc cref="Radioactivity.FromMegarutherfords(OasysUnits.QuantityValue)" />
        public static Radioactivity Megarutherfords<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Radioactivity.FromMegarutherfords(Convert.ToDouble(value));

        /// <inheritdoc cref="Radioactivity.FromMicrobecquerels(OasysUnits.QuantityValue)" />
        public static Radioactivity Microbecquerels<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Radioactivity.FromMicrobecquerels(Convert.ToDouble(value));

        /// <inheritdoc cref="Radioactivity.FromMicrocuries(OasysUnits.QuantityValue)" />
        public static Radioactivity Microcuries<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Radioactivity.FromMicrocuries(Convert.ToDouble(value));

        /// <inheritdoc cref="Radioactivity.FromMicrorutherfords(OasysUnits.QuantityValue)" />
        public static Radioactivity Microrutherfords<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Radioactivity.FromMicrorutherfords(Convert.ToDouble(value));

        /// <inheritdoc cref="Radioactivity.FromMillibecquerels(OasysUnits.QuantityValue)" />
        public static Radioactivity Millibecquerels<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Radioactivity.FromMillibecquerels(Convert.ToDouble(value));

        /// <inheritdoc cref="Radioactivity.FromMillicuries(OasysUnits.QuantityValue)" />
        public static Radioactivity Millicuries<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Radioactivity.FromMillicuries(Convert.ToDouble(value));

        /// <inheritdoc cref="Radioactivity.FromMillirutherfords(OasysUnits.QuantityValue)" />
        public static Radioactivity Millirutherfords<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Radioactivity.FromMillirutherfords(Convert.ToDouble(value));

        /// <inheritdoc cref="Radioactivity.FromNanobecquerels(OasysUnits.QuantityValue)" />
        public static Radioactivity Nanobecquerels<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Radioactivity.FromNanobecquerels(Convert.ToDouble(value));

        /// <inheritdoc cref="Radioactivity.FromNanocuries(OasysUnits.QuantityValue)" />
        public static Radioactivity Nanocuries<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Radioactivity.FromNanocuries(Convert.ToDouble(value));

        /// <inheritdoc cref="Radioactivity.FromNanorutherfords(OasysUnits.QuantityValue)" />
        public static Radioactivity Nanorutherfords<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Radioactivity.FromNanorutherfords(Convert.ToDouble(value));

        /// <inheritdoc cref="Radioactivity.FromPetabecquerels(OasysUnits.QuantityValue)" />
        public static Radioactivity Petabecquerels<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Radioactivity.FromPetabecquerels(Convert.ToDouble(value));

        /// <inheritdoc cref="Radioactivity.FromPicobecquerels(OasysUnits.QuantityValue)" />
        public static Radioactivity Picobecquerels<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Radioactivity.FromPicobecquerels(Convert.ToDouble(value));

        /// <inheritdoc cref="Radioactivity.FromPicocuries(OasysUnits.QuantityValue)" />
        public static Radioactivity Picocuries<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Radioactivity.FromPicocuries(Convert.ToDouble(value));

        /// <inheritdoc cref="Radioactivity.FromPicorutherfords(OasysUnits.QuantityValue)" />
        public static Radioactivity Picorutherfords<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Radioactivity.FromPicorutherfords(Convert.ToDouble(value));

        /// <inheritdoc cref="Radioactivity.FromRutherfords(OasysUnits.QuantityValue)" />
        public static Radioactivity Rutherfords<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Radioactivity.FromRutherfords(Convert.ToDouble(value));

        /// <inheritdoc cref="Radioactivity.FromTerabecquerels(OasysUnits.QuantityValue)" />
        public static Radioactivity Terabecquerels<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Radioactivity.FromTerabecquerels(Convert.ToDouble(value));

        /// <inheritdoc cref="Radioactivity.FromTeracuries(OasysUnits.QuantityValue)" />
        public static Radioactivity Teracuries<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Radioactivity.FromTeracuries(Convert.ToDouble(value));

        /// <inheritdoc cref="Radioactivity.FromTerarutherfords(OasysUnits.QuantityValue)" />
        public static Radioactivity Terarutherfords<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => Radioactivity.FromTerarutherfords(Convert.ToDouble(value));

    }
}
