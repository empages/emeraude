using System;
using System.Collections.Generic;
using System.Linq;

namespace EmPages.Pages.StaticValidation;

/// <summary>
/// Requirements for model properties types supported by the framework.
/// </summary>
public static class TypeRequirements
{
    /// <summary>
    /// Supported types for page models.
    /// </summary>
    public static readonly IReadOnlyCollection<Type> SupportedPrimitivesTypes = new[]
    {
        typeof(string),
        typeof(string[]),
        typeof(char),
        typeof(char?),
        typeof(char[]),
        typeof(bool),
        typeof(bool?),
        typeof(bool[]),
        typeof(byte),
        typeof(byte?),
        typeof(byte[]),
        typeof(sbyte),
        typeof(sbyte?),
        typeof(sbyte[]),
        typeof(short),
        typeof(short?),
        typeof(short[]),
        typeof(ushort),
        typeof(ushort?),
        typeof(ushort[]),
        typeof(int),
        typeof(int?),
        typeof(int[]),
        typeof(uint),
        typeof(uint?),
        typeof(uint[]),
        typeof(long),
        typeof(long?),
        typeof(long[]),
        typeof(ulong),
        typeof(ulong?),
        typeof(ulong[]),
        typeof(float),
        typeof(float?),
        typeof(float[]),
        typeof(double),
        typeof(double?),
        typeof(double[]),
        typeof(decimal),
        typeof(decimal?),
        typeof(decimal[]),
        typeof(DateTime),
        typeof(DateTime?),
        typeof(DateTime[]),
        typeof(DateOnly),
        typeof(DateOnly?),
        typeof(DateOnly[]),
        typeof(TimeOnly),
        typeof(TimeOnly?),
        typeof(TimeOnly[]),
    };

    /// <summary>
    /// Checks whether the specified type is supported by the framework.
    /// </summary>
    /// <param name="type"></param>
    /// <returns></returns>
    public static bool IsTypeSupported(Type type) =>
        SupportedPrimitivesTypes.Contains(type) || type.IsEnum;
}