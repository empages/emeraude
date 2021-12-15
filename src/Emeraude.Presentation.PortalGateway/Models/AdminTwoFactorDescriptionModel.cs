namespace Emeraude.Presentation.PortalGateway.Models;

/// <summary>
/// Model that contains admin two factor authentication description data.
/// </summary>
public class AdminTwoFactorDescriptionModel
{
    /// <summary>
    /// Flag that indicates the current admin has two factor authenticator or not.
    /// </summary>
    public bool HasAuthenticator { get; set; }

    /// <summary>
    /// Flag that indicates the current user has enabled two factor authentication or not.
    /// </summary>
    public bool Is2FaEnabled { get; set; }

    /// <summary>
    /// Key used for manual two factor authentication activation without a QR key.
    /// </summary>
    public string SharedKey { get; set; }

    /// <summary>
    /// Two factor authenticator code used for QR code generation.
    /// </summary>
    public string AuthenticatorUri { get; set; }
}