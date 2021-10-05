using System;
using System.Threading.Tasks;
using Definux.Emeraude.Application.Identity;
using Definux.Emeraude.Application.Localization;
using Definux.Emeraude.Application.Logger;
using Definux.Emeraude.Configuration.Authorization;
using Definux.Emeraude.Configuration.Extensions;
using Definux.Emeraude.Configuration.Options;
using Definux.Emeraude.Localization.Extensions;
using Definux.Utilities.Extensions;
using MediatR;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace Definux.Emeraude.Presentation.Controllers
{
    /// <summary>
    /// Abstraction for controllers which will be used on the client side of the application (not for the administration).
    /// </summary>
    [ApiExplorerSettings(IgnoreApi = true)]
    public abstract class PublicController : EmController
    {
        private const string LanguageCookieName = ".Emeraude.Language";

        private ICurrentLanguageProvider currentLanguageProvider;
        private IUserManager userManager;
        private IEmLocalizer localizer;

        /// <summary>
        /// Ignore <see cref="EmMainOptions.MaintenanceMode"/> from the Emeraude options.
        /// </summary>
        public bool IgnoreMaintenanceMode { get; set; }

        /// <inheritdoc cref="ICurrentLanguageProvider"/>
        protected ICurrentLanguageProvider CurrentLanguageProvider
        {
            get
            {
                if (this.currentLanguageProvider is null)
                {
                    this.currentLanguageProvider = this.HttpContext.RequestServices.GetService<ICurrentLanguageProvider>();
                }

                return this.currentLanguageProvider;
            }
        }

        /// <inheritdoc cref="IUserManager"/>
        protected IUserManager UserManager =>
            this.userManager ??= this.HttpContext.RequestServices.GetService<IUserManager>();

        /// <inheritdoc cref="IEmLocalizer"/>
        protected IEmLocalizer Localizer => this.localizer ??= this.HttpContext.RequestServices.GetService<IEmLocalizer>();

        /// <inheritdoc/>
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            this.ManageLanguageCookie();
            base.OnActionExecuting(context);
        }

        /// <inheritdoc/>
        public override async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            if (!this.IgnoreMaintenanceMode && this.OptionsProvider.GetMainOptions().MaintenanceMode)
            {
                var adminAuthenticationResult = await this.HttpContext.AuthenticateAsync(AuthenticationDefaults.AdminAuthenticationScheme);
                if (!adminAuthenticationResult.Succeeded)
                {
                    context.Result = this.LocalRedirect("/maintenance");
                }
            }

            await base.OnActionExecutionAsync(context, next);
        }

        /// <summary>
        /// Process current language and set language cookie in the client's browser.
        /// </summary>
        [NonAction]
        protected virtual void ManageLanguageCookie()
        {
            var currentLanguage = this.CurrentLanguageProvider.GetCurrentLanguage();
            if (currentLanguage == null || currentLanguage.IsDefault)
            {
                return;
            }

            bool cookieExist = this.HttpContext.Request.Cookies.ContainsKey(LanguageCookieName);

            CookieOptions options = new CookieOptions
            {
                Expires = DateTime.Now.AddYears(1),
                IsEssential = true,
            };

            if (cookieExist)
            {
                this.Response.Cookies.Delete(LanguageCookieName);
            }

            this.Response.Cookies.Append(LanguageCookieName, currentLanguage.Code, options);
        }

        /// <summary>
        /// Get route with language code (async extraction) at the beginning based on current language.
        /// </summary>
        /// <param name="route"></param>
        /// <returns></returns>
        protected async Task<string> GetLanguageRouteAsync(string route)
        {
            var currentLanguage = await this.currentLanguageProvider.GetCurrentLanguageAsync();
            return this.GetRouteWithAppliedLanguage(route, currentLanguage);
        }

        /// <summary>
        /// Get route with language code at the beginning based on current language.
        /// </summary>
        /// <param name="route"></param>
        /// <returns></returns>
        protected string GetLanguageRoute(string route)
        {
            var currentLanguage = this.currentLanguageProvider.GetCurrentLanguage();
            return this.GetRouteWithAppliedLanguage(route, currentLanguage);
        }

        /// <summary>
        /// Redirect to local url merged with current language code (async extraction).
        /// </summary>
        /// <param name="localUrl"></param>
        /// <returns></returns>
        protected async Task<IActionResult> LanguageLocalRedirectAsync(string localUrl)
        {
            return this.LocalRedirect(await this.GetLanguageRouteAsync(localUrl));
        }

        /// <summary>
        /// Redirect to local url merged with current language code.
        /// </summary>
        /// <param name="localUrl"></param>
        /// <returns></returns>
        protected IActionResult LanguageLocalRedirect(string localUrl)
        {
            return this.LocalRedirect(this.GetLanguageRoute(localUrl));
        }

        /// <summary>
        /// Get route parameter or null.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        protected object GetRouteParameterOrNull(string name)
        {
            try
            {
                object value = null;
                this.RouteData.Values.TryGetValue(name, out value);
                return value;
            }
            catch (Exception ex)
            {
                this.Logger.LogError(ex);
                return null;
            }
        }

        /// <summary>
        /// Get route parameter as integer or null.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        protected int? GetInt32RouteParameterOrNull(string name)
        {
            try
            {
                var value = this.GetRouteParameterOrNull(name);
                var convertedValue = Convert.ToInt32(value);
                return convertedValue;
            }
            catch (Exception ex)
            {
                this.Logger.LogError(ex);
                return null;
            }
        }

        /// <summary>
        /// Get route parameter as long or null.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        protected long? GetInt64RouteParameterOrNull(string name)
        {
            try
            {
                var value = this.GetRouteParameterOrNull(name);
                var convertedValue = Convert.ToInt64(value);
                return convertedValue;
            }
            catch (Exception ex)
            {
                this.Logger.LogError(ex);
                return null;
            }
        }

        /// <summary>
        /// Get route parameter as boolean or null.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        protected bool? GetBooleanRouteParameterOrNull(string name)
        {
            try
            {
                var value = this.GetRouteParameterOrNull(name);
                var convertedValue = Convert.ToBoolean(value);
                return convertedValue;
            }
            catch (Exception ex)
            {
                this.Logger.LogError(ex);
                return null;
            }
        }

        /// <summary>
        /// Get route parameter as string or null.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        protected string GetStringRouteParameterOrNull(string name)
        {
            return this.GetRouteParameterOrNull(name)?.ToString();
        }

        /// <summary>
        /// Get route parameter as GUID or null.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        protected Guid? GetGuidRouteParameterOrNull(string name)
        {
            return this.GetRouteParameterOrNull(name)?.GetGuidValueOrDefault();
        }

        /// <summary>
        /// Add a value (translation key) into the ViewData.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value">Translation key.</param>
        protected void AddTranslatedValueIntoViewData(string key, string value)
        {
            this.ViewData[key] = this.Localizer[value];
        }
    }
}