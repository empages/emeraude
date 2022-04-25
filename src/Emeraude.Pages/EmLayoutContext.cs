using System.Collections.Generic;

namespace Emeraude.Pages;

/// <summary>
/// Context implementation for the purposes of layout visualization.
/// </summary>
public class EmLayoutContext
{
    /// <summary>
    /// Order of the layout item that is represented by current context.
    /// </summary>
    public int Order { get; init; }

    /// <summary>
    /// Route of the layout item that is represented by current context.
    /// </summary>
    public string Route { get; init; }

    /// <summary>
    /// Title of the layout item that is represented by current context.
    /// </summary>
    public string Title { get; init; }

    /// <summary>
    /// Icon of the layout item that is represented by current context.
    /// </summary>
    public string Icon { get; init; }

    /// <summary>
    /// Permissions of the layout item that will restrict visibility based on the user permissions.
    /// </summary>
    public IEnumerable<string> Permissions { get; init; }
}