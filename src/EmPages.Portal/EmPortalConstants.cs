namespace EmPages.Portal;

/// <summary>
/// Constants required by the portal.
/// </summary>
public static class EmPortalConstants
{
    /// <summary>
    /// Portal route prefix.
    /// </summary>
    public const string RoutePrefix = "/_em";

    /// <summary>
    /// Portal api route prefix.
    /// </summary>
    public const string RouteApiPrefix = $"{RoutePrefix}/api";

    /// <summary>
    /// Default portal authentication scheme.
    /// </summary>
    public const string AuthenticationScheme = "Em_Bearer";
}