using System;
using System.Security.Claims;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Definux.Emeraude.Application.Identity;
using Definux.Emeraude.Client.Extensions;
using Definux.Emeraude.Configuration.Authorization;
using Definux.Emeraude.Domain.Entities;
using Definux.Emeraude.Identity.Entities;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

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

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientAuthenticationController"/> class.
        /// </summary>
        /// <param name="userClaimsService"></param>
        /// <param name="urlEncoder"></param>
        /// <param name="signInManager"></param>
        /// <param name="externalProviderAuthenticatorFactory"></param>
        public ClientAuthenticationController(
            IUserClaimsService userClaimsService,
            UrlEncoder urlEncoder,
            SignInManager<User> signInManager,
            IExternalProviderAuthenticatorFactory externalProviderAuthenticatorFactory)
        {
            this.userClaimsService = userClaimsService;
            this.urlEncoder = urlEncoder;
            this.signInManager = signInManager;
            this.externalProviderAuthenticatorFactory = externalProviderAuthenticatorFactory;

            this.HideActivityLogParameters = true;
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

            await this.HttpContext.SignOutAsync(AuthenticationDefaults.ClientAuthenticationScheme);

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

            this.AddTranslatedValueIntoViewData(LoginTitle, LoginTitle);
            this.AddTranslatedValueIntoViewData(LoginDescription, LoginDescription);
            this.AddTranslatedValueIntoViewData(RegisterTitle, RegisterTitle);
            this.AddTranslatedValueIntoViewData(RegisterDescription, RegisterDescription);
            this.AddTranslatedValueIntoViewData(ForgotPasswordTitle, ForgotPasswordTitle);
            this.AddTranslatedValueIntoViewData(ForgotPasswordDescription, ForgotPasswordDescription);
            this.AddTranslatedValueIntoViewData(ResetPasswordTitle, ResetPasswordTitle);
            this.AddTranslatedValueIntoViewData(ResetPasswordDescription, ResetPasswordDescription);
            this.AddTranslatedValueIntoViewData(ConfirmEmailTitle, ConfirmEmailTitle);
            this.AddTranslatedValueIntoViewData(ConfirmEmailDescription, ConfirmEmailDescription);

            return base.OnActionExecutionAsync(context, next);
        }

        private async Task SignInAsync(IUser user)
        {
            var claims = await this.userClaimsService.GetUserClaimsForCookieAsync(user.Id);
            var claimsIdentity = new ClaimsIdentity(claims, AuthenticationDefaults.ClientAuthenticationScheme);
            var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

            await this.HttpContext.SignInAsync(
                AuthenticationDefaults.ClientAuthenticationScheme,
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
