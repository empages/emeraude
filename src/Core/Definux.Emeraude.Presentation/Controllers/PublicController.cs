using System;
using System.Threading.Tasks;
using Definux.Emeraude.Application.Common.Interfaces.Identity.Services;
using Definux.Emeraude.Application.Common.Interfaces.Localization;
using Definux.Emeraude.Application.Common.Interfaces.Logging;
using Definux.Emeraude.Localization.Extensions;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.DependencyInjection;

namespace Definux.Emeraude.Presentation.Controllers
{
    /// <summary>
    /// Abstraction for controllers which will be used on the client side of the application (not for the administration).
    /// </summary>
    [ApiExplorerSettings(IgnoreApi = true)]
    public abstract class PublicController : Controller
    {
        private const string LanguageCookieName = ".Emeraude.Language";

        private ILogger logger;
        private ICurrentUserProvider currentUserProvider;
        private ICurrentLanguageProvider currentLanguageProvider;
        private IMediator mediator;
        private IUserManager userManager;

        /// <inheritdoc cref="ILogger"/>
        protected ILogger Logger
        {
            get
            {
                if (this.logger is null)
                {
                    this.logger = this.HttpContext.RequestServices.GetService<ILogger>();
                }

                return this.logger;
            }
        }

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

        /// <inheritdoc cref="ICurrentUserProvider"/>
        protected ICurrentUserProvider CurrentUserProvider
        {
            get
            {
                if (this.currentUserProvider is null)
                {
                    this.currentUserProvider = this.HttpContext.RequestServices.GetService<ICurrentUserProvider>();
                }

                return this.currentUserProvider;
            }
        }

        /// <inheritdoc cref="IMediator"/>
        protected IMediator Mediator
        {
            get
            {
                if (this.mediator is null)
                {
                    this.mediator = this.HttpContext?.RequestServices?.GetService<IMediator>();
                }

                return this.mediator;
            }
        }

        /// <inheritdoc cref="IUserManager"/>
        protected IUserManager UserManager
        {
            get
            {
                if (this.userManager is null)
                {
                    this.userManager = this.HttpContext.RequestServices.GetService<IUserManager>();
                }

                return this.userManager;
            }
        }

        /// <summary>
        /// Flag that activate and disable activity logging by Emeraude logger.
        /// </summary>
        protected bool DisableActivityLog { get; set; }

        /// <summary>
        /// Flag that hide or show the request params in activity log.
        /// </summary>
        protected bool HideActivityLogParameters { get; set; }

        /// <inheritdoc/>
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            this.ManageLanguageCookie();
            if (!this.DisableActivityLog)
            {
                this.Logger.LogActivity(context, this.HideActivityLogParameters);
            }

            base.OnActionExecuting(context);
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
    }
}