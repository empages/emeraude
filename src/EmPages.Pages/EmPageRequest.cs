using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace EmPages.Pages;

/// <summary>
/// Implementation of page request.
/// </summary>
public class EmPageRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EmPageRequest"/> class.
    /// </summary>
    /// <param name="parameters"></param>
    public EmPageRequest(IDictionary<string, object> parameters)
    {
        this.Parameters = new ReadOnlyDictionary<string, object>(parameters);
    }

    /// <summary>
    /// Parameters extracted from the request route.
    /// </summary>
    public IReadOnlyDictionary<string, object> Parameters { get; }

    /// <summary>
    /// Gets casted route parameter.
    /// </summary>
    /// <param name="key"></param>
    /// <param name="defaultValue"></param>
    /// <typeparam name="TType">Type of the parameter.</typeparam>
    /// <returns></returns>
    public TType GetParameter<TType>(string key, TType defaultValue = default)
    {
        return this.GetDictionaryValue<TType>(key, this.Parameters, defaultValue);
    }

    private TType GetDictionaryValue<TType>(string key, IReadOnlyDictionary<string, object> dictionary, TType defaultValue)
    {
        if (!dictionary.ContainsKey(key))
        {
            return defaultValue;
        }

        var value = dictionary[key]?.ToString();

        return EmPageTypeConverter.ConvertToType<TType>(value);
    }
}