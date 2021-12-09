namespace Emeraude.Presentation.PortalGateway.Models;

/// <summary>
/// Wrapped response from the gateway connectivity check.
/// </summary>
public class GatewayResponse
{
    /// <summary>
    /// Gets the verification status of the response.
    /// </summary>
    public bool Verified { get; set; }

    /// <summary>
    /// Current application environment variable.
    /// </summary>
    public string Environment { get; set; }

    /// <summary>
    /// Flag that indicates whether the current instance of the application is in development environment.
    /// </summary>
    public bool IsDevelopment { get; set; }

    /// <summary>
    /// Shows Emeraude Framework version.
    /// </summary>
    public string FrameworkVersion { get; set; }
}