namespace Emeraude.Presentation.PortalGateway.Models;

/// <summary>
/// Login with two factor request for admin authentication.
/// </summary>
public class AdminAuthLoginWithTwoFactorRequest
{
    /// <summary>
    /// Email of the user.
    /// </summary>
    public string Email { get; set; }

    /// <summary>
    /// Two factor authentication code.
    /// </summary>
    public string Code { get; set; }
}