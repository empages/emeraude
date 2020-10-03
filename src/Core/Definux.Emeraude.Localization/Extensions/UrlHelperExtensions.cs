using System;
using Microsoft.AspNetCore.Mvc;

namespace Definux.Emeraude.Localization.Extensions
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
            string languageCode = url.ActionContext.HttpContext.GetLanguageCode();
            string languageCodeRoutePart = string.IsNullOrEmpty(languageCode) ? string.Empty : $"/{languageCode}";
            string actionRoute = url.Action(action, controller, values);
            if (actionRoute.StartsWith("/", StringComparison.OrdinalIgnoreCase) && !string.IsNullOrEmpty(languageCodeRoutePart))
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
