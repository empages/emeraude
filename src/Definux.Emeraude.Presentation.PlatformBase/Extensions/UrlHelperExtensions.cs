using System;
using Definux.Utilities.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace Definux.Emeraude.Presentation.PlatformBase.Extensions
{
    /// <summary>
    /// Extensions for <see cref="IUrlHelper"/>.
    /// </summary>
    public static class UrlHelperExtensions
    {
        /// <summary>
        /// Get transformed route with language code of the current language in case when the current language is not the default one.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="action"></param>
        /// <param name="controller"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string LanguageAction(this IUrlHelper url, string action, string controller, object values = null)
        {
            var languageCode = url.ActionContext.HttpContext.GetRouteValueOrDefault("languageCode", true);
            var languageCodeRoutePart = string.IsNullOrEmpty(languageCode) ? string.Empty : $"/{languageCode}";
            var actionRoute = url.Action(action, controller, values);
            if (actionRoute != null && actionRoute.StartsWith("/", StringComparison.OrdinalIgnoreCase) && !string.IsNullOrEmpty(languageCodeRoutePart))
            {
                actionRoute = $"{languageCodeRoutePart}/{actionRoute.Substring(1)}";
            }
            else if (!string.IsNullOrEmpty(languageCodeRoutePart))
            {
                actionRoute = $"{languageCodeRoutePart}/{actionRoute}";
            }

            return actionRoute;
        }
    }
}
