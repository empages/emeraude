using Definux.Emeraude.Application.Requests.Identity.Commands.ExternalAuthentication;
using Definux.Emeraude.Locales.Attributes;
using Definux.Emeraude.Presentation.Controllers;
using IdentityServer4;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Definux.Emeraude.Client.Controllers.Mvc
{
    public partial class ClientMvcAuthenticationController : PublicController
    {
        public const string ExternalLoginRoute = "/external-login";
        public const string ExternalLoginCallbackRoute = "/external-login/callback";

        [HttpPost]
        [Route(ExternalLoginRoute)]
        [LanguageRoute(ExternalLoginRoute)]
        [ValidateAntiForgeryToken]
        public IActionResult ExternalLogin([FromForm(Name = "externalProvider")]string externalProvider, string returnUrl = "")
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToHomeIndex();
            }

            List<string> allowedProviders = new List<string>();
            if (this.emeraudeOptions.Account.HasFacebookLogin)
            {
                allowedProviders.Add("Facebook");
            }
            if (this.emeraudeOptions.Account.HasGoogleLogin)
            {
                allowedProviders.Add("Google");
            }

            if (!allowedProviders.Contains(externalProvider))
            {
                return NotFound();
            }

            var callbackUrl = GetLanguageRoute($"{ExternalLoginCallbackRoute}?returnUrl={this.urlEncoder.Encode(returnUrl)}");
            var properties = this.signInManager.ConfigureExternalAuthenticationProperties(externalProvider, callbackUrl);

            return Challenge(properties, externalProvider);
        }

        [HttpGet]
        [Route(ExternalLoginCallbackRoute)]
        [LanguageRoute(ExternalLoginCallbackRoute)]
        public async Task<IActionResult> ExternalLoginCallback(string returnUrl)
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToHomeIndex();
            }

            var result = await HttpContext.AuthenticateAsync(IdentityServerConstants.ExternalCookieAuthenticationScheme);
            if (result?.Succeeded != true || result.Principal == null)
            {
                return BadRequest();
            }

            var requestResult = await Mediator.Send(new ExternalAuthenticationCommand(result.Principal));
            if (requestResult.Result.Succeeded)
            {
                await SignInAsync(requestResult.User);
                if (!string.IsNullOrEmpty(returnUrl))
                {
                    return LocalRedirect(returnUrl);
                }

                return RedirectToHomeIndex();
            }

            return RedirectToAction(nameof(Login));
        }
    }
}
