using System;

namespace Emeraude.Presentation.PortalGateway;

/// <summary>
/// Constants of Emeraude Portal.
/// </summary>
public static class EmPortalConstants
{
    /// <summary>
    /// Emeraude portal URL.
    /// </summary>
    public const string EmeraudePortalUrl = "https://emeraude.io";

    /// <summary>
    /// Emeraude portal identification header.
    /// </summary>
    public const string GatewayIdentificationHeader = "Em-Portal-Gateway-Id";

    /// <summary>
    /// Emeraude portal CORS policy name.
    /// </summary>
    public const string CorsPolicyName = "_PortalGatewayPolicy";

    /// <summary>
    /// Emeraude portal identity post authentication purpose.
    /// </summary>
    public const string PostAuthenticationPurpose = "AccessAdministration";

#if DEBUG
    /// <summary>
    /// Default access token expiration.
    /// </summary>
    public static readonly TimeSpan AccessTokenExpiration = TimeSpan.FromDays(1);
#else
    /// <summary>
    /// Default access token expiration.
    /// </summary>
    public static readonly TimeSpan AccessTokenExpiration = TimeSpan.FromHours(1);
#endif
}