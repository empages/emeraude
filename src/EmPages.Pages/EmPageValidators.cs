using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Essentials.Extensions;

namespace EmPages.Pages;

/// <summary>
/// Requirements for model supported by the framework.
/// </summary>
public static class EmPageValidators
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

    /// <summary>
    /// Validates whether a specified model type is valid due the framework requirements.
    /// </summary>
    /// <param name="modelType"></param>
    public static void ValidateModelType(Type modelType)
    {
        if (!modelType.HasInterface<IEmPageModel>())
        {
            throw new EmSetupException($"Error during validation of '{modelType.FullName}'. Model must implements IEmPageModel interface.");
        }

        var publicModelProperties = modelType.GetProperties(BindingFlags.Public | BindingFlags.Instance);
        var incorrectProperties = new List<string>();
        foreach (var publicProperty in publicModelProperties)
        {
            if (!IsTypeSupported(publicProperty.PropertyType))
            {
                incorrectProperties.Add(publicProperty.Name);
            }
        }

        if (incorrectProperties.Any())
        {
            throw new EmSetupException($"Error during validation of '{modelType.FullName}'. The following properties are with unsupported type: [{string.Join(", ", incorrectProperties)}]");
        }
    }
}