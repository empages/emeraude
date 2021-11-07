using System;
using System.Threading.Tasks;
using Definux.Emeraude.Application.Exceptions;
using Definux.Emeraude.Application.Identity.Requests.Commands.ResetPassword;
using Definux.Emeraude.Locales.Attributes;
using Definux.Emeraude.Presentation.Extensions;
using Definux.Emeraude.Presentation.PlatformBase.Extensions;
using Definux.Emeraude.Presentation.PlatformBase.Models;
using Microsoft.AspNetCore.Mvc;

namespace Definux.Emeraude.Presentation.PlatformBase.Controllers
{
    /// <inheritdoc/>
    public abstract partial class UserAuthenticationController
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
        public virtual IActionResult ResetPassword([FromQuery]string token, [FromQuery]string email)
        {
            if (this.IsAuthenticated &&
                !string.Equals(this.User.Identity.Name?.Trim(), email?.Trim(), StringComparison.CurrentCultureIgnoreCase))
            {
                return this.RedirectToDefault();
            }

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrEmpty(token))
            {
                return this.NotFound();
            }

            var viewModel = new ResetPasswordViewModel
            {
                Token = token,
                Email = email,
            };

            return this.ResetPasswordView(viewModel);
        }

        /// <summary>
        /// Reset password action for POST request.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route(ResetPasswordRoute)]
        [LanguageRoute(ResetPasswordRoute)]
        public virtual async Task<IActionResult> ResetPassword(ResetPasswordCommand request)
        {
            if (this.IsAuthenticated &&
                this.User.Identity.Name?.Trim().ToLower() != request.Email?.Trim().ToLower())
            {
                return this.RedirectToDefault();
            }

            try
            {
                var result = await this.Mediator.Send(request);

                if (result.Succeeded)
                {
                    return await this.RedirectToSucceededExecutionResultAsync(
                        Strings.ResetPasswordSuccessful,
                        Strings.YourPasswordHasBeenReset,
                        "reset-password");
                }
                else
                {
                    this.ModelState.AddModelError(string.Empty, Strings.YourPasswordCannotBeReset);
                }
            }
            catch (ValidationException ex)
            {
                this.ModelState.ApplyValidationException(ex);
            }
            catch (Exception)
            {
                this.ModelState.AddModelError(string.Empty, Strings.YourPasswordCannotBeReset);
            }

            return this.ResetPasswordView(request as ResetPasswordViewModel);
        }

        private ViewResult ResetPasswordView(ResetPasswordViewModel model)
        {
            return this.View("ResetPassword", model);
        }
    }
}
