using System;
using System.Threading.Tasks;
using Definux.Emeraude.Application.Exceptions;
using Definux.Emeraude.Application.Requests.Identity.Commands.ForgotPassword;
using Definux.Emeraude.Locales.Attributes;
using Definux.Emeraude.Presentation.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Definux.Emeraude.Client.Controllers.Mvc
{
    /// <inheritdoc/>
    public sealed partial class ClientAuthenticationController : ClientController
    {
        private const string ForgotPasswordRoute = "/forgot-password";

        /// <summary>
        /// Forgot password action for GET request.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route(ForgotPasswordRoute)]
        [LanguageRoute(ForgotPasswordRoute)]
        public IActionResult ForgotPassword()
        {
            if (this.User.Identity.IsAuthenticated)
            {
                return this.RedirectToDefault();
            }

            var request = new ForgotPasswordCommand();

            return this.ForgotPasswordView(request);
        }

        /// <summary>
        /// Forgot password action for POST request.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route(ForgotPasswordRoute)]
        [LanguageRoute(ForgotPasswordRoute)]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordCommand request)
        {
            if (this.User.Identity.IsAuthenticated)
            {
                return this.RedirectToDefault();
            }

            try
            {
                var result = await this.Mediator.Send(request);
                if (!result.Succeeded)
                {
                    this.logger.LogWarning("Invalid email {Email} from reset password form", request.Email);
                }

                return await this.RedirectToSucceededExecutionResultAsync(
                    Strings.SuccessfulResetPasswordRequestHasBeenMade,
                    Strings.ALinkForResetPasswordHasBeenSentToYou,
                    "forgot-password");
            }
            catch (ValidationException ex)
            {
                this.ModelState.ApplyValidationException(ex);
            }
            catch (Exception)
            {
                this.ModelState.AddModelError(string.Empty, Strings.YourPasswordCannotBeReset);
            }

            return this.ForgotPasswordView(request);
        }

        private ViewResult ForgotPasswordView(object model)
        {
            return this.View("ForgotPassword", model);
        }
    }
}
