using System;
using System.Threading.Tasks;
using Definux.Emeraude.Application.Exceptions;
using Definux.Emeraude.Application.Requests.Identity.Commands.Login;
using Definux.Emeraude.Locales.Attributes;
using Definux.Emeraude.Localization.Extensions;
using Definux.Emeraude.Presentation.Controllers;
using Definux.Emeraude.Presentation.Extensions;
using Definux.Emeraude.Resources;
using Microsoft.AspNetCore.Mvc;

namespace Definux.Emeraude.Client.Controllers.Mvc
{
    /// <inheritdoc/>
    public sealed partial class ClientMvcAuthenticationController : PublicController
    {
        private const string LoginRoute = "/login";

        /// <summary>
        /// Login action for GET request.
        /// </summary>
        /// <param name="returnUrl"></param>
        /// <returns></returns>
        [HttpGet]
        [Route(LoginRoute)]
        [LanguageRoute(LoginRoute)]
        public IActionResult Login(string returnUrl = null)
        {
            if (this.User.Identity.IsAuthenticated)
            {
                return this.RedirectToHomeIndex();
            }

            string returnUrlLanguageCode = returnUrl.GetLanguageCodeFromUrl();

            var request = new LoginRequest();
            this.ViewData["ReturnUrl"] = returnUrl;

            if (!string.IsNullOrEmpty(returnUrlLanguageCode) && string.IsNullOrEmpty(this.HttpContext.GetLanguageCode()))
            {
                return this.LocalRedirect($"/{returnUrlLanguageCode}{LoginRoute}?returnUrl={this.urlEncoder.Encode(returnUrl)}");
            }
            else
            {
                return this.LoginView(request);
            }
        }

        /// <summary>
        /// Login action for GET request.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="returnUrl"></param>
        /// <returns></returns>
        [HttpPost]
        [Route(LoginRoute)]
        [LanguageRoute(LoginRoute)]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginRequest request, string returnUrl = "")
        {
            if (this.User.Identity.IsAuthenticated)
            {
                return this.RedirectToHomeIndex();
            }

            try
            {
                var requestResult = await this.Mediator.Send(new LoginCommand(request));

                if (requestResult.Result.Succeeded)
                {
                    await this.SignInAsync(requestResult.User);
                    if (string.IsNullOrWhiteSpace(returnUrl))
                    {
                        return this.RedirectToHomeIndex();
                    }

                    return this.LocalRedirect(returnUrl);
                }
                else if (requestResult.Result.IsLockedOut)
                {
                    return this.View("Lockout");
                }
                else
                {
                    this.ModelState.AddModelError(string.Empty, Messages.YourEmailOrPasswordIsIncorrect);
                }
            }
            catch (ValidationException ex)
            {
                this.ModelState.ApplyValidationException(ex);
            }
            catch (Exception)
            {
                this.ModelState.AddModelError(string.Empty, Messages.YourLoginAttemptHasFailed);
            }

            this.ViewData["ReturnUrl"] = returnUrl;

            return this.LoginView(request);
        }

        private ViewResult LoginView(object model)
        {
            return this.View("Login", model);
        }
    }
}
