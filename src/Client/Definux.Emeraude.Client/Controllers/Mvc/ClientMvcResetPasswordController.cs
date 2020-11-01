using System;
using System.Threading.Tasks;
using Definux.Emeraude.Application.Exceptions;
using Definux.Emeraude.Application.Requests.Identity.Commands.ResetPassword;
using Definux.Emeraude.Locales.Attributes;
using Definux.Emeraude.Presentation.Controllers;
using Definux.Emeraude.Presentation.Extensions;
using Definux.Emeraude.Resources;
using Microsoft.AspNetCore.Mvc;

namespace Definux.Emeraude.Client.Controllers.Mvc
{
    /// <inheritdoc/>
    public sealed partial class ClientMvcAuthenticationController : PublicController
    {
        private const string ResetPasswordRoute = "/reset-password";

        /// <summary>
        /// Reset password action for GET request.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="email"></param>
        /// <returns></returns>
        [HttpGet]
        [Route(ResetPasswordRoute)]
        [LanguageRoute(ResetPasswordRoute)]
        public IActionResult ResetPassword([FromQuery]string token, [FromQuery]string email)
        {
            if (this.User.Identity.IsAuthenticated)
            {
                return this.RedirectToHomeIndex();
            }

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrEmpty(token))
            {
                return this.NotFound();
            }

            var request = new ResetPasswordCommand
            {
                Token = token,
                Email = email,
            };

            return this.ResetPasswordView(request);
        }

        /// <summary>
        /// Reset password action for POST request.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route(ResetPasswordRoute)]
        [LanguageRoute(ResetPasswordRoute)]
        public async Task<IActionResult> ResetPassword(ResetPasswordCommand request)
        {
            if (this.User.Identity.IsAuthenticated)
            {
                return this.RedirectToHomeIndex();
            }

            try
            {
                var requestResult = await this.Mediator.Send(request);

                if (requestResult.Successed)
                {
                    return this.ResetPasswordSuccessView(request);
                }
                else
                {
                    this.ModelState.AddModelError(string.Empty, Messages.YourPasswordCannotBeReset);
                }
            }
            catch (ValidationException ex)
            {
                this.ModelState.ApplyValidationException(ex);
            }
            catch (Exception)
            {
                this.ModelState.AddModelError(string.Empty, Messages.YourPasswordCannotBeReset);
            }

            return this.ResetPasswordView(request);
        }

        private ViewResult ResetPasswordView(object model)
        {
            return this.View("ResetPassword", model);
        }

        private ViewResult ResetPasswordSuccessView(object model)
        {
            return this.View("ResetPasswordSuccess", model);
        }
    }
}
