// Copyright (c) Microsoft and Contributors. All rights reserved. Licensed under the University of Illinois/NCSA Open Source License. See LICENSE.txt in the project root for license information.

using System;

namespace ClangSharp
{
    [Flags]
    public enum PInvokeGeneratorConfigurationOptions
    {
        None = 0x00000000,

        GenerateMultipleFiles = 0x00000001,

        GenerateUnixTypes = 0x00000002,

        NoDefaultRemappings = 0x00000004,

        GenerateCompatibleCode = 0x00000008,

        GenerateNInt = 0x00000010,

        GenerateFnptr = 0x00000020,

        GeneratePreviewCode = GenerateNInt | GenerateFnptr,

        LogExclusions = 0x00000040,

        LogVisitedFiles = 0x00000080,

        GenerateExplicitVtbls = 0x00000100,

        GenerateTestsNUnit = 0x00000200,

        GenerateTestsXUnit = 0x00000400,

        GenerateMacroBindings = 0x00000800,

        ExcludeComProxies = 0x00001000,

        ExcludeEmptyRecords = 0x00002000,

        ExcludeEnumOperators = 0x00004000,

        GenerateAggressiveInlining = 0x00008000,

        GenerateCompatibleIfdef = 0x00010000,

        GenerateUnsafeAsPointer = 0x00020000,
    }
}
