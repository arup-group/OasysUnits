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
using OasysUnits.Units;

namespace OasysUnits
{
    /// <inheritdoc />
    /// <summary>
    ///     Molar energy is the amount of energy stored in 1 mole of a substance.
    /// </summary>
    public struct  MolarEnergy
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly MolarEnergyUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public MolarEnergyUnit Unit => _unit;

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public MolarEnergy(double value, MolarEnergyUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of MolarEnergy, which is Second. All conversions go via this value.
        /// </summary>
        public static MolarEnergyUnit BaseUnit { get; } = MolarEnergyUnit.JoulePerMole;

        /// <summary>
        /// Represents the largest possible value of MolarEnergy.
        /// </summary>
        public static MolarEnergy MaxValue { get; } = new MolarEnergy(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of MolarEnergy.
        /// </summary>
        public static MolarEnergy MinValue { get; } = new MolarEnergy(double.MinValue, BaseUnit);

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static MolarEnergy Zero { get; } = new MolarEnergy(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="MolarEnergyUnit.JoulePerMole"/>
        /// </summary>
        public double JoulesPerMole => As(MolarEnergyUnit.JoulePerMole);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="MolarEnergyUnit.KilojoulePerMole"/>
        /// </summary>
        public double KilojoulesPerMole => As(MolarEnergyUnit.KilojoulePerMole);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="MolarEnergyUnit.MegajoulePerMole"/>
        /// </summary>
        public double MegajoulesPerMole => As(MolarEnergyUnit.MegajoulePerMole);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="MolarEnergy"/> from <see cref="MolarEnergyUnit.JoulePerMole"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MolarEnergy FromJoulesPerMole(double joulespermole) => new MolarEnergy(joulespermole, MolarEnergyUnit.JoulePerMole);

        /// <summary>
        ///     Creates a <see cref="MolarEnergy"/> from <see cref="MolarEnergyUnit.KilojoulePerMole"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MolarEnergy FromKilojoulesPerMole(double kilojoulespermole) => new MolarEnergy(kilojoulespermole, MolarEnergyUnit.KilojoulePerMole);

        /// <summary>
        ///     Creates a <see cref="MolarEnergy"/> from <see cref="MolarEnergyUnit.MegajoulePerMole"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MolarEnergy FromMegajoulesPerMole(double megajoulespermole) => new MolarEnergy(megajoulespermole, MolarEnergyUnit.MegajoulePerMole);

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="MolarEnergyUnit" /> to <see cref="MolarEnergy" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>MolarEnergy unit value.</returns>
        public static MolarEnergy From(double value, MolarEnergyUnit fromUnit)
        {
            return new MolarEnergy(value, fromUnit);
        }

        #endregion

                #region Conversion Methods

                /// <summary>
                ///     Convert to the unit representation <paramref name="unit" />.
                /// </summary>
                /// <returns>Value converted to the specified unit.</returns>
                public double As(MolarEnergyUnit unit) => GetValueAs(unit);

                /// <summary>
                ///     Converts this MolarEnergy to another MolarEnergy with the unit representation <paramref name="unit" />.
                /// </summary>
                /// <returns>A MolarEnergy with the specified unit.</returns>
                public MolarEnergy ToUnit(MolarEnergyUnit unit)
                {
                    var convertedValue = GetValueAs(unit);
                    return new MolarEnergy(convertedValue, unit);
                }

                /// <summary>
                ///     Converts the current value + unit to the base unit.
                ///     This is typically the first step in converting from one unit to another.
                /// </summary>
                /// <returns>The value in the base unit representation.</returns>
                private double GetValueInBaseUnit()
                {
                    return Unit switch
                    {
                        MolarEnergyUnit.JoulePerMole => _value,
                        MolarEnergyUnit.KilojoulePerMole => (_value) * 1e3d,
                        MolarEnergyUnit.MegajoulePerMole => (_value) * 1e6d,
                        _ => throw new NotImplementedException($"Can not convert {Unit} to base units.")
                    };
                    }

                private double GetValueAs(MolarEnergyUnit unit)
                {
                    if (Unit == unit)
                        return _value;

                    var baseUnitValue = GetValueInBaseUnit();

                    return unit switch
                    {
                        MolarEnergyUnit.JoulePerMole => baseUnitValue,
                        MolarEnergyUnit.KilojoulePerMole => (baseUnitValue) / 1e3d,
                        MolarEnergyUnit.MegajoulePerMole => (baseUnitValue) / 1e6d,
                        _ => throw new NotImplementedException($"Can not convert {Unit} to {unit}.")
                    };
                    }

                #endregion
    }
}

