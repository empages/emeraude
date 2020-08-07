using Definux.Emeraude.Localization.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace Definux.Emeraude.Client.Extensions
{
    public static class UrlHelperExtensions
    {
        public const string AuthenticationControllerName = "ClientMvcAuthentication";
        public const string ReturnUrlKey = "ReturnUrl";

        public static string GetAuthenticationControllerName(this IUrlHelper urlHelper)
        {
            return AuthenticationControllerName;
        }

        public static string LoginAction(this IUrlHelper urlHelper, ViewDataDictionary viewData)
        {
            return urlHelper.LanguageAction("Login", AuthenticationControllerName, new { returnUrl = viewData[ReturnUrlKey] });
        }

        public static string RegisterAction(this IUrlHelper urlHelper)
        {
            return urlHelper.LanguageAction("Register", AuthenticationControllerName);
        }

        public static string ForgotPasswordAction(this IUrlHelper urlHelper)
        {
            return urlHelper.LanguageAction("ForgotPassword", AuthenticationControllerName);
        }

        public static string ResetPasswordAction(this IUrlHelper urlHelper)
        {
            return urlHelper.LanguageAction("ResetPassword", AuthenticationControllerName);
        }
    }
}
