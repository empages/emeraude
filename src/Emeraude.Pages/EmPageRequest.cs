using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Emeraude.Pages;

/// <summary>
/// Implementation of page request.
/// </summary>
public class EmPageRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EmPageRequest"/> class.
    /// </summary>
    /// <param name="routeParameters"></param>
    /// <param name="queryParameters"></param>
    public EmPageRequest(IDictionary<string, object> routeParameters, IDictionary<string, object> queryParameters)
    {
        this.RouteParameters = new ReadOnlyDictionary<string, object>(routeParameters);
        this.QueryParameters = new ReadOnlyDictionary<string, object>(queryParameters);
    }

    /// <summary>
    /// Parameters extracted from the request route.
    /// </summary>
    public IReadOnlyDictionary<string, object> RouteParameters { get; }

    /// <summary>
    /// Parameters extracted from the query string of the request.
    /// </summary>
    public IReadOnlyDictionary<string, object> QueryParameters { get; }

    /// <summary>
    /// Gets casted route parameter.
    /// </summary>
    /// <param name="key"></param>
    /// <typeparam name="TType">Type of the parameter.</typeparam>
    /// <returns></returns>
    public TType GetRouteParameter<TType>(string key)
    {
        return this.GetDictionaryValue<TType>(key, this.RouteParameters);
    }

    /// <summary>
    /// Gets casted query parameter.
    /// </summary>
    /// <param name="key"></param>
    /// <typeparam name="TType">Type of the parameter.</typeparam>
    /// <returns></returns>
    public TType GetQueryParameter<TType>(string key)
    {
        return this.GetDictionaryValue<TType>(key, this.QueryParameters);
    }

    private TType GetDictionaryValue<TType>(string key, IReadOnlyDictionary<string, object> dictionary)
    {
        if (!dictionary.ContainsKey(key))
        {
            return default;
        }

        var value = dictionary[key];

        return (TType)Convert.ChangeType(value, typeof(TType));
    }
}