using Definux.Emeraude.Localization.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace Definux.Emeraude.Client.Extensions
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
    }
}
