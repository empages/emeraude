namespace EmPages.PortalGateway;

/// <summary>
/// Constants required by the portal gateway.
/// </summary>
public static class EmPortalGatewayConstants
{
    /// <summary>
    /// EmPages portal identification header.
    /// </summary>
    public const string GatewayIdentificationHeader = "X-Em-Portal-Gateway-Id";

    /// <summary>
    /// EmPages portal CORS policy name.
    /// </summary>
    public const string CorsPolicyName = "_PortalGatewayPolicy";

    /// <summary>
    /// Portal gateway route prefix.
    /// </summary>
    public const string RoutePrefix = "/__em";
}