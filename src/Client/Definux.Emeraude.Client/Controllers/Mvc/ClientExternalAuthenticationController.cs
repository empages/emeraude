using System.Collections.Generic;
using System.Threading.Tasks;
using Definux.Emeraude.Application.Requests.Identity.Commands.ExternalAuthentication;
using Definux.Emeraude.Locales.Attributes;
using Definux.Emeraude.Presentation.Controllers;
using IdentityServer4;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace Definux.Emeraude.Client.Controllers.Mvc
{
    /// <inheritdoc/>
    public sealed partial class ClientAuthenticationController : ClientController
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
        public IActionResult ExternalLogin([FromForm(Name = "externalProvider")]string externalProvider, string returnUrl = "")
        {
            if (!this.Options.Account.HasExternalAuthentication)
            {
                return this.NotFound();
            }

            if (this.User.Identity.IsAuthenticated)
            {
                return this.RedirectToHomeIndex();
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
        public async Task<IActionResult> ExternalLoginCallback(string returnUrl)
        {
            if (this.User.Identity.IsAuthenticated)
            {
                return this.RedirectToHomeIndex();
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
                if (!string.IsNullOrEmpty(returnUrl))
                {
                    return this.LocalRedirect(returnUrl);
                }

                return this.RedirectToHomeIndex();
            }

            return this.RedirectToAction(nameof(this.Login));
        }
    }
}
