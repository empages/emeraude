namespace EmPages.Portal.Models;

/// <summary>
/// Implementation of portal state.
/// </summary>
public class EmPortalState
{
    /// <summary>
    /// Name of the framework.
    /// </summary>
    public string Framework { get; set; }

    /// <summary>
    /// Current version of the framework.
    /// </summary>
    public string Version { get; init; }

    /// <summary>
    /// Source application environment.
    /// </summary>
    public string Environment { get; init; }
}