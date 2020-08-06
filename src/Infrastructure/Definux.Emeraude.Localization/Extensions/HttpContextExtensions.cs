using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace Definux.Emeraude.Localization.Extensions
{
    public static class HttpContextExtensions
    {
        public static string GetLanguageCode(this HttpContext httpContext)
        {
            var route = httpContext.GetRouteData();
            object language = string.Empty;
            string languageCode = string.Empty;
            route.Values.TryGetValue("languageCode", out language);
            if (language != null)
            {
                languageCode = language.ToString().ToLower();
            }

            return languageCode;
        }
    }
}
