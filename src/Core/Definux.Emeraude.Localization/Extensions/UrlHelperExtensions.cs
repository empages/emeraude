using Microsoft.AspNetCore.Mvc;
using System;

namespace Definux.Emeraude.Localization.Extensions
{
    public static class UrlHelperExtensions
    {
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
