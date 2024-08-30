﻿// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/OasysUnits.

using System;
using System.Linq;
using System.Reflection;
using Xunit;

namespace OasysUnits.Tests
{
    public class AssemblyAttributeTests
    {
        [Fact]
        public static void AssemblyShouldBeClsCompliant()
        {
            var assembly = typeof(Length).GetTypeInfo().Assembly;

            var attributes = assembly.CustomAttributes.Select(x => x.AttributeType);
            Assert.Contains(typeof(CLSCompliantAttribute), attributes);
        }

        [Fact]
        public static void AssemblyCopyrightShouldContain2013()
        {
            var assembly = typeof(Length).GetTypeInfo().Assembly;

            var copyrightAttribute = assembly
                .CustomAttributes
                .Single(x => x.AttributeType == typeof(AssemblyCopyrightAttribute));
            var copyrightString = copyrightAttribute.ConstructorArguments.Single().Value!.ToString()!;
            Assert.Contains("2013", copyrightString);
        }
    }
}
