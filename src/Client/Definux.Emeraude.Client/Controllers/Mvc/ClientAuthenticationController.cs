using System;
using System.Security.Claims;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Definux.Emeraude.Application.Identity;
using Definux.Emeraude.Client.Extensions;
using Definux.Emeraude.Domain.Entities;
using Definux.Emeraude.Essentials.Base;
using Definux.Emeraude.Identity.Entities;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;

namespace Definux.Emeraude.Client.Controllers.Mvc
{
    /// <summary>
    /// Client controller for MVC authentication.
    /// </summary>
    public sealed partial class ClientAuthenticationController : ClientController
    {
        private const string LogoutRoute = "/logout";

        private readonly IUserClaimsService userClaimsService;
        private readonly UrlEncoder urlEncoder;
        private readonly SignInManager<User> signInManager;
        private readonly IExternalProviderAuthenticatorFactory externalProviderAuthenticatorFactory;
        private readonly ILogger<ClientAuthenticationController> logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientAuthenticationController"/> class.
        /// </summary>
        /// <param name="userClaimsService"></param>
        /// <param name="urlEncoder"></param>
        /// <param name="signInManager"></param>
        /// <param name="externalProviderAuthenticatorFactory"></param>
        /// <param name="logger"></param>
        public ClientAuthenticationController(
            IUserClaimsService userClaimsService,
            UrlEncoder urlEncoder,
            SignInManager<User> signInManager,
            IExternalProviderAuthenticatorFactory externalProviderAuthenticatorFactory,
            ILogger<ClientAuthenticationController> logger)
        {
            this.userClaimsService = userClaimsService;
            this.urlEncoder = urlEncoder;
            this.signInManager = signInManager;
            this.externalProviderAuthenticatorFactory = externalProviderAuthenticatorFactory;
            this.logger = logger;
        }

        private AuthenticationProperties AuthenticationProperties
        {
            get
            {
                return new AuthenticationProperties
                {
                    IsPersistent = true,
                    ExpiresUtc = DateTime.UtcNow.AddMonths(1),
                };
            }
        }

        /// <summary>
        /// Logout action for GET and POST requests.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [HttpPost]
        [Route(LogoutRoute)]
        public async Task<IActionResult> Logout()
        {
            if (!this.User.Identity.IsAuthenticated)
            {
                return this.BadRequest();
            }

            await this.HttpContext.SignOutAsync(EmAuthenticationDefaults.ClientAuthenticationScheme);

            return this.RedirectToDefault();
        }

        /// <inheritdoc/>
        public override ViewResult View(string viewName, object model)
        {
            return base.View($"Authentication/{viewName}", model);
        }

        /// <inheritdoc/>
        public override Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            if (!this.OptionsProvider.GetClientOptions().HasClientMvcAuthentication)
            {
                context.Result = this.NotFound();
            }

            return base.OnActionExecutionAsync(context, next);
        }

        private async Task SignInAsync(IUser user)
        {
            var claims = await this.userClaimsService.GetUserClaimsForCookieAsync(user.Id);
            var claimsIdentity = new ClaimsIdentity(claims, EmAuthenticationDefaults.ClientAuthenticationScheme);
            var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

            await this.HttpContext.SignInAsync(
                EmAuthenticationDefaults.ClientAuthenticationScheme,
                claimsPrincipal,
                this.AuthenticationProperties);
        }

        private IActionResult RedirectToDefault()
        {
            var redirectCallback = this.OptionsProvider.GetClientOptions().ClientAuthenticationDefaultRedirectCallback;
            return redirectCallback != null
                ? redirectCallback.Invoke(this.HttpContext)
                : this.RedirectToAction("Index", "Home");
        }
    }
}
