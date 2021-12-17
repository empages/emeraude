using Emeraude.Essentials.Extensions;
using Microsoft.AspNetCore.Http;

namespace Emeraude.Infrastructure.Localization.Extensions;

/// <summary>
/// Extensions for <see cref="HttpContext"/>.
/// </summary>
public static class HttpContextExtensions
{
    /// <summary>
    /// Get language code from current instance of <see cref="HttpContext"/>.
    /// </summary>
    /// <param name="httpContext"></param>
    /// <returns></returns>
    public static string GetLanguageCode(this HttpContext httpContext)
    {
        return httpContext.GetRouteValueOrDefault("languageCode", true);
    }
}