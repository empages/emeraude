﻿using Definux.Emeraude.Essentials.Attributes;

namespace Definux.Emeraude.Essentials.Enumerations
{
    /// <summary>
    /// Types of cases for strings.
    /// </summary>
    public enum StringCaseType
    {
        [EnumName("asd")]
        CamelCase = 1,
        PascalCase = 2,
        KebapCase = 3,
        SnakeCase = 4,
        SnaceCaseAllCaps = 5,
    }
}
