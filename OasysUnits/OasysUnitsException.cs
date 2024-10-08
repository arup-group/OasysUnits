﻿// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;

namespace OasysUnits
{
    /// <summary>
    ///     The base type for OasysUnits exceptions.
    /// </summary>
    public class OasysUnitsException : Exception
    {
        /// <inheritdoc />
        public OasysUnitsException()
        {
            HResult = 1;
        }

        /// <inheritdoc />
        public OasysUnitsException(string message) : base(message)
        {
            HResult = 1;
        }

        /// <inheritdoc />
        public OasysUnitsException(string message, Exception innerException) : base(message, innerException)
        {
            HResult = 1;
        }
    }
}
