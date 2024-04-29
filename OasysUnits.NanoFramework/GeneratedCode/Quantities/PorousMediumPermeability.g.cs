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
    ///     
    /// </summary>
    /// <remarks>
    ///     https://en.wikipedia.org/wiki/Permeability_(Earth_sciences)
    /// </remarks>
    public struct  PorousMediumPermeability
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly PorousMediumPermeabilityUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public PorousMediumPermeabilityUnit Unit => _unit;

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public PorousMediumPermeability(double value, PorousMediumPermeabilityUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of PorousMediumPermeability, which is Second. All conversions go via this value.
        /// </summary>
        public static PorousMediumPermeabilityUnit BaseUnit { get; } = PorousMediumPermeabilityUnit.SquareMeter;

        /// <summary>
        /// Represents the largest possible value of PorousMediumPermeability.
        /// </summary>
        public static PorousMediumPermeability MaxValue { get; } = new PorousMediumPermeability(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of PorousMediumPermeability.
        /// </summary>
        public static PorousMediumPermeability MinValue { get; } = new PorousMediumPermeability(double.MinValue, BaseUnit);

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static PorousMediumPermeability Zero { get; } = new PorousMediumPermeability(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="PorousMediumPermeabilityUnit.Darcy"/>
        /// </summary>
        public double Darcys => As(PorousMediumPermeabilityUnit.Darcy);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="PorousMediumPermeabilityUnit.Microdarcy"/>
        /// </summary>
        public double Microdarcys => As(PorousMediumPermeabilityUnit.Microdarcy);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="PorousMediumPermeabilityUnit.Millidarcy"/>
        /// </summary>
        public double Millidarcys => As(PorousMediumPermeabilityUnit.Millidarcy);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="PorousMediumPermeabilityUnit.SquareCentimeter"/>
        /// </summary>
        public double SquareCentimeters => As(PorousMediumPermeabilityUnit.SquareCentimeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="PorousMediumPermeabilityUnit.SquareMeter"/>
        /// </summary>
        public double SquareMeters => As(PorousMediumPermeabilityUnit.SquareMeter);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="PorousMediumPermeability"/> from <see cref="PorousMediumPermeabilityUnit.Darcy"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PorousMediumPermeability FromDarcys(double darcys) => new PorousMediumPermeability(darcys, PorousMediumPermeabilityUnit.Darcy);

        /// <summary>
        ///     Creates a <see cref="PorousMediumPermeability"/> from <see cref="PorousMediumPermeabilityUnit.Microdarcy"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PorousMediumPermeability FromMicrodarcys(double microdarcys) => new PorousMediumPermeability(microdarcys, PorousMediumPermeabilityUnit.Microdarcy);

        /// <summary>
        ///     Creates a <see cref="PorousMediumPermeability"/> from <see cref="PorousMediumPermeabilityUnit.Millidarcy"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PorousMediumPermeability FromMillidarcys(double millidarcys) => new PorousMediumPermeability(millidarcys, PorousMediumPermeabilityUnit.Millidarcy);

        /// <summary>
        ///     Creates a <see cref="PorousMediumPermeability"/> from <see cref="PorousMediumPermeabilityUnit.SquareCentimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PorousMediumPermeability FromSquareCentimeters(double squarecentimeters) => new PorousMediumPermeability(squarecentimeters, PorousMediumPermeabilityUnit.SquareCentimeter);

        /// <summary>
        ///     Creates a <see cref="PorousMediumPermeability"/> from <see cref="PorousMediumPermeabilityUnit.SquareMeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PorousMediumPermeability FromSquareMeters(double squaremeters) => new PorousMediumPermeability(squaremeters, PorousMediumPermeabilityUnit.SquareMeter);

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="PorousMediumPermeabilityUnit" /> to <see cref="PorousMediumPermeability" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>PorousMediumPermeability unit value.</returns>
        public static PorousMediumPermeability From(double value, PorousMediumPermeabilityUnit fromUnit)
        {
            return new PorousMediumPermeability(value, fromUnit);
        }

        #endregion

                #region Conversion Methods

                /// <summary>
                ///     Convert to the unit representation <paramref name="unit" />.
                /// </summary>
                /// <returns>Value converted to the specified unit.</returns>
                public double As(PorousMediumPermeabilityUnit unit) => GetValueAs(unit);

                /// <summary>
                ///     Converts this PorousMediumPermeability to another PorousMediumPermeability with the unit representation <paramref name="unit" />.
                /// </summary>
                /// <returns>A PorousMediumPermeability with the specified unit.</returns>
                public PorousMediumPermeability ToUnit(PorousMediumPermeabilityUnit unit)
                {
                    var convertedValue = GetValueAs(unit);
                    return new PorousMediumPermeability(convertedValue, unit);
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
                        PorousMediumPermeabilityUnit.Darcy => _value * 9.869233e-13,
                        PorousMediumPermeabilityUnit.Microdarcy => (_value * 9.869233e-13) * 1e-6d,
                        PorousMediumPermeabilityUnit.Millidarcy => (_value * 9.869233e-13) * 1e-3d,
                        PorousMediumPermeabilityUnit.SquareCentimeter => _value * 1e-4,
                        PorousMediumPermeabilityUnit.SquareMeter => _value,
                        _ => throw new NotImplementedException($"Can not convert {Unit} to base units.")
                    };
                    }

                private double GetValueAs(PorousMediumPermeabilityUnit unit)
                {
                    if (Unit == unit)
                        return _value;

                    var baseUnitValue = GetValueInBaseUnit();

                    return unit switch
                    {
                        PorousMediumPermeabilityUnit.Darcy => baseUnitValue / 9.869233e-13,
                        PorousMediumPermeabilityUnit.Microdarcy => (baseUnitValue / 9.869233e-13) / 1e-6d,
                        PorousMediumPermeabilityUnit.Millidarcy => (baseUnitValue / 9.869233e-13) / 1e-3d,
                        PorousMediumPermeabilityUnit.SquareCentimeter => baseUnitValue / 1e-4,
                        PorousMediumPermeabilityUnit.SquareMeter => baseUnitValue,
                        _ => throw new NotImplementedException($"Can not convert {Unit} to {unit}.")
                    };
                    }

                #endregion
    }
}

