using System;
using Definux.Utilities.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace Definux.Emeraude.Client.UI.Extensions
{
    /// <summary>
    /// Extensions for <see cref="IUrlHelper"/>.
    /// </summary>
    public static class UrlHelperExtensions
    {
        /// <summary>
        /// Client authentication controller name.
        /// </summary>
        public const string AuthenticationControllerName = "ClientMvcAuthentication";

        /// <summary>
        /// Return url query param name.
        /// </summary>
        public const string ReturnUrlKey = "ReturnUrl";

        /// <summary>
        /// Get the client authentication controller name.
        /// </summary>
        /// <param name="urlHelper"></param>
        /// <returns></returns>
        public static string GetAuthenticationControllerName(this IUrlHelper urlHelper)
        {
            return AuthenticationControllerName;
        }

        /// <summary>
        /// Generates login action URL.
        /// </summary>
        /// <param name="urlHelper"></param>
        /// <param name="viewData"></param>
        /// <returns></returns>
        public static string LoginAction(this IUrlHelper urlHelper, ViewDataDictionary viewData)
        {
            return urlHelper.LanguageAction("Login", AuthenticationControllerName, new { returnUrl = viewData[ReturnUrlKey] });
        }

        /// <summary>
        /// Generates external login action URL.
        /// </summary>
        /// <param name="urlHelper"></param>
        /// <param name="viewData"></param>
        /// <returns></returns>
        public static string ExternalLoginAction(this IUrlHelper urlHelper, ViewDataDictionary viewData)
        {
            return urlHelper.LanguageAction("ExternalLogin", AuthenticationControllerName, new { returnUrl = viewData[ReturnUrlKey] });
        }

        /// <summary>
        /// Generates register action URL.
        /// </summary>
        /// <param name="urlHelper"></param>
        /// <returns></returns>
        public static string RegisterAction(this IUrlHelper urlHelper)
        {
            return urlHelper.LanguageAction("Register", AuthenticationControllerName);
        }

        /// <summary>
        /// Generates forgot password action URL.
        /// </summary>
        /// <param name="urlHelper"></param>
        /// <returns></returns>
        public static string ForgotPasswordAction(this IUrlHelper urlHelper)
        {
            return urlHelper.LanguageAction("ForgotPassword", AuthenticationControllerName);
        }

        /// <summary>
        /// Generates reset password action URL.
        /// </summary>
        /// <param name="urlHelper"></param>
        /// <returns></returns>
        public static string ResetPasswordAction(this IUrlHelper urlHelper)
        {
            return urlHelper.LanguageAction("ResetPassword", AuthenticationControllerName);
        }

        /// <summary>
        /// Generates index action URL (Index action from HomeController).
        /// </summary>
        /// <param name="urlHelper"></param>
        /// <returns></returns>
        public static string IndexAction(this IUrlHelper urlHelper)
        {
            return urlHelper.LanguageAction("Index", "Home");
        }

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
            string languageCode = url.ActionContext.HttpContext.GetRouteValueOrDefault("languageCode", true);
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
