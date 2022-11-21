using System.Collections.Generic;
using System.Linq;

namespace EmPages.Pages;

/// <summary>
/// Represents request and all relevant arguments mapped to it.
/// </summary>
public class EmRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EmRequest"/> class.
    /// </summary>
    public EmRequest()
    {
        this.Parameters = new List<EmParameter>();
    }

    /// <summary>
    /// Request route.
    /// </summary>
    public string Route { get; set; }

    /// <summary>
    /// Command identifier.
    /// </summary>
    public string Command { get; set; }

    /// <summary>
    /// Request parameters.
    /// </summary>
    public IEnumerable<EmParameter> Parameters { get; set; }

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
        return new EmPageRequest(this.Parameters.ToDictionary(x => x.Key, x => x.Value));
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
            this.Parameters.ToDictionary(x => x.Key, x => x.Value));
    }
}