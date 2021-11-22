using System;
using System.Threading.Tasks;
using Definux.Emeraude.Locales.Attributes;
using Emeraude.Application.Exceptions;
using Emeraude.Application.Identity.Requests.Commands.Register;
using Emeraude.Presentation.Extensions;
using Emeraude.Presentation.PlatformBase.Extensions;
using Emeraude.Presentation.PlatformBase.Models;
using Microsoft.AspNetCore.Mvc;

namespace Emeraude.Presentation.PlatformBase.Controllers
{
    /// <inheritdoc cref="UserAuthenticationController"/>
    public abstract partial class UserAuthenticationController
    {
        private const string RegisterRoute = "/register";

        /// <summary>
        /// Register action for GET request.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route(RegisterRoute)]
        [LanguageRoute(RegisterRoute)]
        public IActionResult Register()
        {
            if (this.IsAuthenticated)
            {
                return this.RedirectToDefault();
            }

            var viewModel = new RegisterViewModel();

            return this.RegisterView(viewModel);
        }

        /// <summary>
        /// Register action for POST request.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route(RegisterRoute)]
        [LanguageRoute(RegisterRoute)]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterCommand request)
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
                    return await this.RedirectToSucceededExecutionResultAsync(
                        Strings.RegistrationHasBeenSuccessful,
                        Strings.PleaseConfirmYourEmailAddressToCompleteTheRegistration,
                        "register");
                }

                this.ModelState.AddModelError(string.Empty, Strings.UserCannotBeRegistered);
            }
            catch (ValidationException ex)
            {
                this.ModelState.ApplyValidationException(ex);
            }
            catch (Exception)
            {
                this.ModelState.AddModelError(string.Empty, Strings.UserCannotBeRegistered);
            }

            return this.RegisterView(request as RegisterViewModel);
        }

        private ViewResult RegisterView(RegisterViewModel model)
        {
            return this.View("Register", model);
        }
    }
}
