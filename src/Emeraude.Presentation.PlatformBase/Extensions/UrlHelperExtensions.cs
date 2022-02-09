using System;
using System.Collections.Generic;
using Emeraude.Essentials.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace Emeraude.Presentation.PlatformBase.Extensions;

/// <summary>
/// Extensions for <see cref="IUrlHelper"/>.
/// </summary>
public static class UrlHelperExtensions
{
    /// <summary>
    /// Returns current language code.
    /// </summary>
    /// <param name="url"></param>
    /// <returns></returns>
    public static string LanguageCode(this IUrlHelper url) =>
        url.ActionContext.HttpContext.GetRouteValueOrDefault("languageCode", true);

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
        string routeLanguageCode = url.LanguageCode();
        var languageCodeRoutePrefix = string.IsNullOrEmpty(routeLanguageCode) ? string.Empty : $"/{routeLanguageCode}";
        var actionRoute = url.Action(action, controller, values);
        if (actionRoute != null && actionRoute.StartsWith("/", StringComparison.OrdinalIgnoreCase) && !string.IsNullOrEmpty(languageCodeRoutePrefix))
        {
            actionRoute = $"{languageCodeRoutePrefix}/{actionRoute.Substring(1)}";
        }
        else if (!string.IsNullOrEmpty(languageCodeRoutePrefix))
        {
            actionRoute = $"{languageCodeRoutePrefix}/{actionRoute}";
        }

        return actionRoute;
    }

    /// <summary>
    /// Get transformed route with language code of the current language in case when the current language is not the default one.
    /// </summary>
    /// <param name="url"></param>
    /// <param name="languageCode"></param>
    /// <returns></returns>
    public static string LanguageAction(this IUrlHelper url, string languageCode = null)
    {
        var action = url.ActionContext.RouteData.Values["action"]?.ToString();
        var controller = url.ActionContext.RouteData.Values["controller"]?.ToString();
        var routeValues = (Dictionary<string, string>)url.ActionContext.ActionDescriptor.RouteValues;
        string routeLanguageCode = url.LanguageCode();

        var currentUrl = url.Action(action, controller, routeValues);
        if (currentUrl.StartsWith($"/{routeLanguageCode}"))
        {
            currentUrl = currentUrl.Substring(routeLanguageCode.Length + 1);
        }

        if (!currentUrl.StartsWith("/"))
        {
            currentUrl = $"/{currentUrl}";
        }

        if (!string.IsNullOrWhiteSpace(languageCode))
        {
            currentUrl = $"/{languageCode}{currentUrl}";
        }

        return currentUrl;
    }
}