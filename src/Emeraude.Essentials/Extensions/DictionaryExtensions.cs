using System.Collections;
using System.Collections.Generic;

namespace Emeraude.Essentials.Extensions;

/// <summary>
/// Extensions for dictionaries.
/// </summary>
public static class DictionaryExtensions
{
    /// <summary>
    /// Gets value or default for specified key.
    /// </summary>
    /// <param name="dictionary"></param>
    /// <param name="key"></param>
    /// <typeparam name="TKey">Dictionary key type.</typeparam>
    /// <typeparam name="TValue">Dictionary value type.</typeparam>
    /// <returns></returns>
    public static TValue GetValueOrDefault<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key) =>
        dictionary.ContainsKey(key) ? dictionary[key] : default;
}