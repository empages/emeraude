using System.Threading.Tasks;
using Emeraude.Application.Identity.Requests.Commands.ExternalAuthentication;
using Emeraude.Infrastructure.Identity.Extensions;
using Emeraude.Infrastructure.Localization.Attributes;
using IdentityServer4;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace Emeraude.Presentation.PlatformBase.Controllers
{
    /// <inheritdoc cref="UserAuthenticationController"/>
    public abstract partial class UserAuthenticationController
    {
        private const string ExternalLoginRoute = "/external-login";
        private const string ExternalLoginCallbackRoute = "/external-login/callback";

        /// <summary>
        /// External login action.
        /// </summary>
        /// <param name="externalProvider"></param>
        /// <param name="returnUrl"></param>
        /// <returns></returns>
        [HttpPost]
        [Route(ExternalLoginRoute)]
        [LanguageRoute(ExternalLoginRoute)]
        [ValidateAntiForgeryToken]
        public virtual IActionResult ExternalLogin([FromForm(Name = "externalProvider")]string externalProvider, string returnUrl = "")
        {
            if (!this.OptionsProvider.GetIdentityOptions().HasExternalAuthentication)
            {
                return this.NotFound();
            }

            if (this.IsAuthenticated)
            {
                return this.RedirectToDefault();
            }

            if (!this.externalProviderAuthenticatorFactory.ContainsProvider(externalProvider))
            {
                return this.NotFound();
            }

            var callbackUrl = this.GetLanguageRoute($"{ExternalLoginCallbackRoute}?returnUrl={this.urlEncoder.Encode(returnUrl)}");
            var properties = this.signInManager.ConfigureExternalAuthenticationProperties(externalProvider, callbackUrl);

            return this.Challenge(properties, externalProvider);
        }

        /// <summary>
        /// External login callback action.
        /// </summary>
        /// <param name="returnUrl"></param>
        /// <returns></returns>
        [HttpGet]
        [Route(ExternalLoginCallbackRoute)]
        [LanguageRoute(ExternalLoginCallbackRoute)]
        public virtual async Task<IActionResult> ExternalLoginCallback(string returnUrl)
        {
            if (this.IsAuthenticated)
            {
                return this.RedirectToDefault();
            }

            var result = await this.HttpContext.AuthenticateAsync(IdentityServerConstants.ExternalCookieAuthenticationScheme);
            if (result?.Succeeded != true || result.Principal == null)
            {
                return this.BadRequest();
            }

            var requestResult = await this.Mediator.Send(new ExternalAuthenticationCommand(result.Principal));
            if (requestResult.Result.Succeeded)
            {
                await this.SignInAsync(requestResult.User);
                return !string.IsNullOrEmpty(returnUrl) ? this.LocalRedirect(returnUrl) : this.RedirectToDefault();
            }

            // ReSharper disable once Mvc.ActionNotResolved
            return this.RedirectToAction(nameof(this.Login));
        }
    }
}
