using System;
using System.Security.Claims;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Definux.Emeraude.Application.Identity;
using Definux.Emeraude.Configuration.Authorization;
using Definux.Emeraude.Configuration.Options;
using Definux.Emeraude.Domain.Entities;
using Definux.Emeraude.Identity.Entities;
using Definux.Emeraude.Presentation.Controllers;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Options;

namespace Definux.Emeraude.Client.Controllers.Mvc
{
    /// <summary>
    /// Client controller for MVC authentication.
    /// </summary>
    public sealed partial class ClientMvcAuthenticationController : PublicController
    {
        private const string LogoutRoute = "/logout";

        private readonly IUserClaimsService userClaimsService;
        private readonly UrlEncoder urlEncoder;
        private readonly EmOptions emeraudeOptions;
        private readonly SignInManager<User> signInManager;

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientMvcAuthenticationController"/> class.
        /// </summary>
        /// <param name="userClaimsService"></param>
        /// <param name="urlEncoder"></param>
        /// <param name="emeraudeOptionsAccessor"></param>
        /// <param name="signInManager"></param>
        public ClientMvcAuthenticationController(
            IUserClaimsService userClaimsService,
            UrlEncoder urlEncoder,
            IOptions<EmOptions> emeraudeOptionsAccessor,
            SignInManager<User> signInManager)
        {
            this.userClaimsService = userClaimsService;
            this.urlEncoder = urlEncoder;
            this.emeraudeOptions = emeraudeOptionsAccessor.Value;
            this.signInManager = signInManager;

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

            return this.RedirectToHomeIndex();
        }

        /// <inheritdoc/>
        public override ViewResult View(string viewName, object model)
        {
            return base.View($"Authentication/{viewName}", model);
        }

        /// <inheritdoc/>
        public override Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            if (!this.emeraudeOptions.Account.HasClientMvcAuthentication)
            {
                context.Result = this.NotFound();
            }

            this.AddTranslatedValueIntoViewData(LoginTitle, this.Localizer.TranslateKey(LoginTitle));
            this.AddTranslatedValueIntoViewData(LoginDescription, this.Localizer.TranslateKey(LoginDescription));
            this.AddTranslatedValueIntoViewData(RegisterTitle, this.Localizer.TranslateKey(RegisterTitle));
            this.AddTranslatedValueIntoViewData(RegisterDescription, this.Localizer.TranslateKey(RegisterDescription));
            this.AddTranslatedValueIntoViewData(ForgotPasswordTitle, this.Localizer.TranslateKey(ForgotPasswordTitle));
            this.AddTranslatedValueIntoViewData(ForgotPasswordDescription, this.Localizer.TranslateKey(ForgotPasswordDescription));
            this.AddTranslatedValueIntoViewData(ResetPasswordTitle, this.Localizer.TranslateKey(ResetPasswordTitle));
            this.AddTranslatedValueIntoViewData(ResetPasswordDescription, this.Localizer.TranslateKey(ResetPasswordDescription));
            this.AddTranslatedValueIntoViewData(ConfirmEmailTitle, this.Localizer.TranslateKey(ConfirmEmailTitle));
            this.AddTranslatedValueIntoViewData(ConfirmEmailDescription, this.Localizer.TranslateKey(ConfirmEmailDescription));

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

        private IActionResult RedirectToHomeIndex()
        {
            return this.RedirectToAction("Index", "Home");
        }
    }
}
