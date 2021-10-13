using System;
using System.Threading.Tasks;
using Definux.Emeraude.Application.Exceptions;
using Definux.Emeraude.Application.Requests.Identity.Commands.Register;
using Definux.Emeraude.Client.Models;
using Definux.Emeraude.Locales.Attributes;
using Definux.Emeraude.Presentation.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace Definux.Emeraude.Client.Controllers.Mvc
{
    /// <inheritdoc/>
    public sealed partial class ClientAuthenticationController : ClientController
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
            if (this.User.Identity.IsAuthenticated)
            {
                return this.RedirectToDefault();
            }

            var request = new RegisterCommand();

            return this.RegisterView(request);
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
            if (this.User.Identity.IsAuthenticated)
            {
                return this.RedirectToDefault();
            }

            try
            {
                var requestResult = await this.Mediator.Send(request);

                if (requestResult.Result.Succeeded)
                {
                    return await this.RedirectToSucceededExecutionResultAsync(
                        Strings.RegistrationHasBeenSuccessful,
                        Strings.PleaseConfirmYourEmailAddressToCompleteTheRegistration,
                        "register");
                }
                else
                {
                    this.ModelState.AddModelError(string.Empty, Strings.UserCannotBeRegistered);
                }
            }
            catch (ValidationException ex)
            {
                this.ModelState.ApplyValidationException(ex);
            }
            catch (Exception)
            {
                this.ModelState.AddModelError(string.Empty, Strings.UserCannotBeRegistered);
            }

            return this.RegisterView(request);
        }

        private ViewResult RegisterView(object model)
        {
            return this.View("Register", model);
        }
    }
}
