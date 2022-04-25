namespace Emeraude.PortalGateway;

/// <summary>
/// Constants required by the portal gateway.
/// </summary>
public static class EmPortalGatewayConstants
{
    /// <summary>
    /// Emeraude portal identification header.
    /// </summary>
    public const string GatewayIdentificationHeader = "Em-Portal-Gateway-Id";

    /// <summary>
    /// Emeraude portal CORS policy name.
    /// </summary>
    public const string CorsPolicyName = "_PortalGatewayPolicy";

    /// <summary>
    /// Portal gateway route prefix.
    /// </summary>
    public const string RoutePrefix = "/_em/api";
}