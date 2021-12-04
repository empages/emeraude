namespace Emeraude.Presentation.PortalGateway.Models;

/// <summary>
/// Login request for admin authentication.
/// </summary>
public class AdminAuthLoginRequest
{
    /// <summary>
    /// Email of the user.
    /// </summary>
    public string Email { get; set; }

    /// <summary>
    /// Password of the user.
    /// </summary>
    public string Password { get; set; }
}