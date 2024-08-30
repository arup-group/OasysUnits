// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/OasysUnits.

using System;

namespace CodeGen.Exceptions
{
    internal class OasysUnitsCodeGenException : Exception
    {
        public OasysUnitsCodeGenException(string message) : base(message)
        {
        }

        public OasysUnitsCodeGenException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
