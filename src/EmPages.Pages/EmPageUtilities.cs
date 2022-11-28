using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using Essentials.Extensions;
using Essentials.Functions;

namespace EmPages.Pages;

/// <summary>
/// Static utilities for extraction data for the purposes of EmPages.
/// </summary>
public static class EmPageUtilities
{
    /// <summary>
    /// Generates a unique type ID.
    /// </summary>
    /// <param name="idBase"></param>
    /// <returns></returns>
    public static string GenerateTypeId(string idBase = null)
    {
        var typeIdBase = Guid.NewGuid().ToString();
        if (!string.IsNullOrWhiteSpace(idBase))
        {
            typeIdBase = idBase;
        }

        return CryptoFunctions.MD5Hash($"EM_TYPE_ID_{typeIdBase}").ToLower();
    }

    /// <summary>
    /// Extracts enum dictionary from a specified type.
    /// </summary>
    /// <param name="enumType"></param>
    /// <returns></returns>
    public static IDictionary<object, string> GetEnumDictionary(Type enumType)
    {
        var resultDictionary = new Dictionary<object, string>();
        var enumValues = enumType.GetEnumValues();
        foreach (var value in enumValues)
        {
            var enumValue = Enum.Parse(enumType, value.ToString());
            resultDictionary[enumValue] = enumValue.ToString();
        }

        return resultDictionary;
    }

    /// <summary>
    /// Gets available properties from EmPage Model type.
    /// </summary>
    /// <param name="type"></param>
    /// <returns></returns>
    public static IEnumerable<PropertyInfo> GetEmPageModelProperties(Type type) =>
        type
            .GetProperties(BindingFlags.Public | BindingFlags.Instance)
            .Where(x => x.GetGetMethod()?.IsPublic ?? false);
}