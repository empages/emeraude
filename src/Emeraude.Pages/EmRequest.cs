using System.Collections.Generic;
using System.Linq;

namespace Emeraude.Pages;

/// <summary>
/// Represents request and all relevant arguments mapped to it.
/// </summary>
public class EmRequest
{
    /// <summary>
    /// Request route.
    /// </summary>
    public string Route { get; set; }

    /// <summary>
    /// Command identifier.
    /// </summary>
    public string Command { get; set; }

    /// <summary>
    /// Parameters extracted by the query string.
    /// </summary>
    public IEnumerable<EmParameter> QueryParameters { get; set; }

    /// <summary>
    /// Parameters extracted by the route.
    /// </summary>
    public IEnumerable<EmParameter> RouteParameters { get; set; }

    /// <summary>
    /// Model passed by the page.
    /// </summary>
    public IEmPageModel Model { get; set; }

    /// <summary>
    /// Models IDs passed by the page.
    /// </summary>
    public IEnumerable<string> ModelsIds { get; set; }

    /// <summary>
    /// Converts current request to a page request.
    /// </summary>
    /// <returns></returns>
    public EmPageRequest ToPageRequest()
    {
        return new EmPageRequest(
            this.RouteParameters.ToDictionary(x => x.Key, x => x.Value),
            this.QueryParameters.ToDictionary(x => x.Key, x => x.Value));
    }

    /// <summary>
    /// Converts current request to page command request.
    /// </summary>
    /// <returns></returns>
    public EmPageCommandRequest ToCommandPageRequest()
    {
        return new EmPageCommandRequest(
            this.Model,
            this.ModelsIds,
            this.RouteParameters.ToDictionary(x => x.Key, x => x.Value),
            this.QueryParameters.ToDictionary(x => x.Key, x => x.Value));
    }
}