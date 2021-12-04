using System.Linq;

namespace Emeraude.Essentials.Helpers;

/// <summary>
/// Static URL helpers.
/// </summary>
public static class UrlHelpers
{
    /// <summary>
    /// Builds a relative URL.
    /// </summary>
    /// <param name="segments"></param>
    /// <returns></returns>
    public static string BuildRelativeUrl(params string[] segments)
    {
        return $"/{string.Join("/", segments.Select(x => x.Trim()))}";
    }

    /// <summary>
    /// Builds an absolute URL.
    /// </summary>
    /// <param name="baseUrl"></param>
    /// <param name="segments"></param>
    /// <returns></returns>
    public static string BuildAbsoluteUrl(string baseUrl, params string[] segments)
    {
        return $"{baseUrl}{BuildRelativeUrl(segments)}";
    }
}