using System;
using System.Threading.Tasks;
using Definux.Emeraude.Application.Exceptions;
using Definux.Emeraude.Application.Identity.Requests.Commands.Login;
using Definux.Emeraude.Infrastructure.Localization.Extensions;
using Definux.Emeraude.Locales.Attributes;
using Definux.Emeraude.Presentation.Extensions;
using Definux.Emeraude.Presentation.PlatformBase.Models;
using Microsoft.AspNetCore.Mvc;

namespace Definux.Emeraude.Presentation.PlatformBase.Controllers
{
    /// <inheritdoc/>
    public abstract partial class UserAuthenticationController
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
        public virtual IActionResult Login(string returnUrl = null)
        {
            if (this.IsAuthenticated)
            {
                return this.RedirectToDefault();
            }

            var returnUrlLanguageCode = returnUrl.GetLanguageCodeFromUrl();
            var viewModel = new LoginViewModel();
            this.ViewData["ReturnUrl"] = returnUrl;
            if (!string.IsNullOrEmpty(returnUrlLanguageCode) && string.IsNullOrEmpty(this.HttpContext.GetLanguageCode()))
            {
                return this.LocalRedirect($"/{returnUrlLanguageCode}{LoginRoute}?returnUrl={this.urlEncoder.Encode(returnUrl)}");
            }

            return this.LoginView(viewModel);
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
        public virtual async Task<IActionResult> Login(LoginCommand request, string returnUrl = "")
        {
            if (this.IsAuthenticated)
            {
                return this.RedirectToDefault();
            }

            try
            {
                var result = await this.Mediator.Send(request);

                if (result.Result.Succeeded)
                {
                    await this.SignInAsync(result.User);
                    if (string.IsNullOrWhiteSpace(returnUrl))
                    {
                        return this.RedirectToDefault();
                    }

                    return this.LocalRedirect(returnUrl);
                }

                if (result.Result.IsLockedOut)
                {
                    return this.View("Lockout");
                }

                this.ModelState.AddModelError(string.Empty, Strings.TheEmailAddressOrPasswordIsIncorrect);
            }
            catch (ValidationException ex)
            {
                this.ModelState.ApplyValidationException(ex);
            }
            catch (Exception)
            {
                this.ModelState.AddModelError(string.Empty, Strings.YourLoginAttemptHasFailed);
            }

            this.ViewData["ReturnUrl"] = returnUrl;

            return this.LoginView(request as LoginViewModel);
        }

        private ViewResult LoginView(LoginViewModel model)
        {
            return this.View("Login", model);
        }
    }
}
