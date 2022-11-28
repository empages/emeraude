using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace EmPages.Pages;

/// <summary>
/// Static data supporting the EmPages.
/// </summary>
public static class EmPageStaticData
{
    /// <summary>
    /// Texts group types.
    /// </summary>
    public static readonly IReadOnlyCollection<Type> TextsGroupTypes = new[]
    {
        typeof(string),
        typeof(char),
    };

    /// <summary>
    /// Booleans group types.
    /// </summary>
    public static readonly IReadOnlyCollection<Type> BooleansGroupTypes = new[]
    {
        typeof(bool),
    };

    /// <summary>
    /// Numbers group types.
    /// </summary>
    public static readonly IReadOnlyCollection<Type> NumbersGroupTypes = new[]
    {
        typeof(byte),
        typeof(sbyte),
        typeof(short),
        typeof(ushort),
        typeof(int),
        typeof(uint),
        typeof(long),
        typeof(ulong),
        typeof(float),
        typeof(double),
        typeof(decimal),
    };

    /// <summary>
    /// Date times group types.
    /// </summary>
    public static readonly IReadOnlyCollection<Type> DateTimesGroupTypes = new[]
    {
        typeof(DateTime),
        typeof(DateOnly),
        typeof(TimeOnly),
    };

    /// <summary>
    /// Supported types for page models.
    /// </summary>
    public static readonly IReadOnlyCollection<Type> SupportedPrimitivesTypes;

    /// <summary>
    /// Supported types for page models.
    /// </summary>
    public static readonly IReadOnlyCollection<Type> SupportedNullablePrimitivesTypes = new[]
    {
        typeof(string),
        typeof(bool?),
        typeof(char?),
        typeof(byte?),
        typeof(sbyte?),
        typeof(short?),
        typeof(ushort?),
        typeof(int?),
        typeof(uint?),
        typeof(long?),
        typeof(ulong?),
        typeof(long?),
        typeof(float?),
        typeof(double?),
        typeof(decimal?),
        typeof(DateTime?),
        typeof(DateOnly?),
        typeof(TimeOnly?),
    };

    /// <summary>
    /// Supported base generic types for page models.
    /// </summary>
    public static readonly IReadOnlyCollection<Type> SupportedBaseGenericTypes = new[]
    {
        typeof(IEnumerable<>),
    };

    static EmPageStaticData()
    {
        var supportedPrimitiveTypes = new List<Type>();
        supportedPrimitiveTypes.AddRange(TextsGroupTypes);
        supportedPrimitiveTypes.AddRange(NumbersGroupTypes);
        supportedPrimitiveTypes.AddRange(BooleansGroupTypes);
        supportedPrimitiveTypes.AddRange(DateTimesGroupTypes);

        SupportedPrimitivesTypes = supportedPrimitiveTypes;
    }
}