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
    public IList<EmParameter> Parameters { get; set; }
}