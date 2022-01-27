using System.Linq;
using Pluralize.NET;

namespace Emeraude.Essentials.Extensions;

/// <summary>
/// Extensions for <see cref="string"/>.
/// </summary>
public static class StringExtensions
{
    private static readonly IPluralize Pluralizer = new Pluralizer();

    /// <summary>
    /// Get plural form of string.
    /// </summary>
    /// <param name="targetString"></param>
    /// <returns></returns>
    public static string ToPluralString(this string targetString)
    {
        return Pluralizer.Pluralize(targetString);
    }

    /// <summary>
    /// Get singular form of a string.
    /// </summary>
    /// <param name="targetString"></param>
    /// <returns></returns>
    public static string ToSingularString(this string targetString)
    {
        return Pluralizer.Singularize(targetString);
    }

    /// <summary>
    /// Transforms the first char of string in uppercase.
    /// </summary>
    /// <param name="stringValue"></param>
    /// <returns></returns>
    public static string ToFirstUpper(this string stringValue)
    {
        return stringValue.First().ToString().ToUpper() + stringValue.Substring(1);
    }

    /// <summary>
    /// Transforms the first char of string in lowercase.
    /// </summary>
    /// <param name="stringValue"></param>
    /// <returns></returns>
    public static string ToFirstLower(this string stringValue)
    {
        return stringValue.First().ToString().ToLower() + stringValue.Substring(1);
    }
}