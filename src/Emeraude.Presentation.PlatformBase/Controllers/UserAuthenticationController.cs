using System;
using System.Security.Claims;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Emeraude.Application.Consumer.Extensions;
using Emeraude.Contracts;
using Emeraude.Essentials.Base;
using Emeraude.Infrastructure.Identity.Entities;
using Emeraude.Infrastructure.Identity.ExternalProviders;
using Emeraude.Infrastructure.Identity.Services;
using Emeraude.Presentation.Controllers;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;

namespace Emeraude.Presentation.PlatformBase.Controllers
{
    /// <summary>
    /// User authentication controller.
    /// </summary>
    public abstract partial class UserAuthenticationController : PublicController
    {
        private const string LogoutRoute = "/logout";

        private readonly IUserClaimsService userClaimsService;
        private readonly UrlEncoder urlEncoder;
        private readonly SignInManager<User> signInManager;
        private readonly IExternalProviderAuthenticatorFactory externalProviderAuthenticatorFactory;
        private readonly ILogger<UserAuthenticationController> logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserAuthenticationController"/> class.
        /// </summary>
        /// <param name="userClaimsService"></param>
        /// <param name="urlEncoder"></param>
        /// <param name="signInManager"></param>
        /// <param name="externalProviderAuthenticatorFactory"></param>
        /// <param name="logger"></param>
        protected UserAuthenticationController(
            IUserClaimsService userClaimsService,
            UrlEncoder urlEncoder,
            SignInManager<User> signInManager,
            IExternalProviderAuthenticatorFactory externalProviderAuthenticatorFactory,
            ILogger<UserAuthenticationController> logger)
        {
            this.userClaimsService = userClaimsService;
            this.urlEncoder = urlEncoder;
            this.signInManager = signInManager;
            this.externalProviderAuthenticatorFactory = externalProviderAuthenticatorFactory;
            this.logger = logger;
        }

        /// <summary>
        /// Gets authentication properties.
        /// </summary>
        protected virtual AuthenticationProperties AuthenticationProperties =>
            new ()
            {
                IsPersistent = true,
                ExpiresUtc = DateTime.UtcNow.AddMonths(1),
            };

        protected bool IsAuthenticated =>
            this.User?.Identity?.IsAuthenticated ?? false;

        /// <summary>
        /// Logout action for GET and POST requests.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [HttpPost]
        [Route(LogoutRoute)]
        public virtual async Task<IActionResult> Logout()
        {
            if (!this.IsAuthenticated)
            {
                return this.BadRequest();
            }

            await this.HttpContext.SignOutAsync(EmAuthenticationDefaults.CookieAuthenticationScheme);

            return this.RedirectToDefault();
        }

        /// <summary>
        /// Registers the user principle in the session.
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        protected virtual async Task SignInAsync(IUser user)
        {
            var claims = await this.userClaimsService.GetUserClaimsForCookieAsync(user.Id);
            var claimsIdentity = new ClaimsIdentity(claims, EmAuthenticationDefaults.CookieAuthenticationScheme);
            var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

            await this.HttpContext.SignInAsync(
                EmAuthenticationDefaults.CookieAuthenticationScheme,
                claimsPrincipal,
                this.AuthenticationProperties);
        }

        private IActionResult RedirectToDefault()
        {
            var redirectCallback = this.OptionsProvider.GetClientOptions().AuthenticationDefaultRedirectCallback;
            return redirectCallback != null
                ? redirectCallback.Invoke(this.HttpContext)
                : this.RedirectToAction("Index", "Home");
        }
    }
}
