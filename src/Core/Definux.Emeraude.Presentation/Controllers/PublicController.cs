using Definux.Emeraude.Application.Common.Interfaces.Identity.Services;
using Definux.Emeraude.Application.Common.Interfaces.Localization;
using Definux.Emeraude.Application.Common.Interfaces.Logging;
using Definux.Emeraude.Domain.Localization;
using Definux.Emeraude.Localization.Extensions;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace Definux.Emeraude.Presentation.Controllers
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public abstract class PublicController : Controller
    {
        protected const string LanguageCookieName = ".Emeraude.Language";

        private ILogger logger;
        private ICurrentUserProvider currentUserProvider;
        private ICurrentLanguageProvider currentLanguageProvider;
        private IMediator mediator;
        private IUserManager userManager;

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

        protected IMediator Mediator
        {
            get
            {
                if (this.mediator is null)
                {
                    this.mediator = HttpContext?.RequestServices?.GetService<IMediator>();
                }

                return this.mediator;
            }
        }

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

        public bool DisableActivityLog { get; set; }

        public bool HideActivityLogParameters { get; set; }


        public override void OnActionExecuting(ActionExecutingContext context)
        {
            ManageLanguageCookie();
            if (!DisableActivityLog)
            {
                Logger.LogActivity(context, HideActivityLogParameters);
            }

            base.OnActionExecuting(context);
        }

        [NonAction]
        protected void ManageLanguageCookie()
        {
            var currentLanguage = CurrentLanguageProvider.GetCurrentLanguage();
            if (currentLanguage == null || currentLanguage.IsDefault)
            {
                return;
            }

            bool cookieExist = this.HttpContext.Request.Cookies.ContainsKey(LanguageCookieName);

            CookieOptions options = new CookieOptions
            {
                Expires = DateTime.Now.AddYears(1),
                IsEssential = true
            };

            if (cookieExist)
            {
                this.Response.Cookies.Delete(LanguageCookieName);
            }
            this.Response.Cookies.Append(LanguageCookieName, currentLanguage.Code, options);
        }

        protected async Task<string> GetLanguageRouteAsync(string route)
        {
            var currentLanguage = await this.currentLanguageProvider.GetCurrentLanguageAsync();
            return this.GetRouteWithAppliedLanguage(route, currentLanguage);
        }

        protected string GetLanguageRoute(string route)
        {
            var currentLanguage = this.currentLanguageProvider.GetCurrentLanguage();
            return this.GetRouteWithAppliedLanguage(route, currentLanguage);
        }

        protected async Task<IActionResult> LanguageLocalRedirectAsync(string localUrl)
        {
            return LocalRedirect(await GetLanguageRouteAsync(localUrl));
        }

        protected IActionResult LanguageLocalRedirect(string localUrl)
        {
            return LocalRedirect(GetLanguageRoute(localUrl));
        }
    }
}