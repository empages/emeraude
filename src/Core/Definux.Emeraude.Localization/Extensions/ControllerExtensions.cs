using Definux.Emeraude.Domain.Localization;
using Microsoft.AspNetCore.Mvc;

namespace Definux.Emeraude.Localization.Extensions
{
    public static class ControllerExtensions
    {
        public static string GetRouteWithAppliedLanguage(this Controller controller, string route, Language language)
        {
            if (language != null && !language.IsDefault)
            {
                if (route.StartsWith("/"))
                {
                    route = route.Substring(1);
                }

                return $"/{language.Code}/{route}";
            }

            return route;
        }
    }
}
