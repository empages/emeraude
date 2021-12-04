namespace Emeraude.Infrastructure.Identity.Options;

/// <summary>
/// Implementation of access token (JWT) options.
/// </summary>
public class AccessTokenOptions
{
    /// <summary>
    /// Secret key of the token.
    /// </summary>
    public string Key { get; set; }

    /// <summary>
    /// Issuer of the token.
    /// </summary>
    public string Issuer { get; set; }

    /// <summary>
    /// Seconds that indicate the valid time of the access token. Default is 900 (15 minutes).
    /// </summary>
    public int Expiration { get; set; } = 900;
}