namespace Emeraude.Infrastructure.Identity.Options;

/// <summary>
/// Implementation of OAuth2 settings.
/// </summary>
public class OAuth2Settings
{
    /// <summary>
    /// Name of the external provider.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Client id.
    /// </summary>
    public string ClientId { get; set; }

    /// <summary>
    /// Client secret.
    /// </summary>
    public string ClientSecret { get; set; }
}