namespace EmPages.PortalGateway.Models;

/// <summary>
/// Implementation of portal gateway state.
/// </summary>
public class EmPortalGatewayState
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