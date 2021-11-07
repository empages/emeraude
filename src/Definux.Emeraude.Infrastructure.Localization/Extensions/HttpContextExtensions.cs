using Definux.Utilities.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace Definux.Emeraude.Infrastructure.Localization.Extensions
{
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
}
