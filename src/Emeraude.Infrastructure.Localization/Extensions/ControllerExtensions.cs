using Emeraude.Infrastructure.Localization.Persistence.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Emeraude.Infrastructure.Localization.Extensions
{
    /// <summary>
    /// Extensions for <see cref="Controller"/>.
    /// </summary>
    public static class ControllerExtensions
    {
        /// <summary>
        /// Gets route with applied language code on the beginning.
        /// </summary>
        /// <param name="controller"></param>
        /// <param name="route"></param>
        /// <param name="language"></param>
        /// <returns></returns>
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
