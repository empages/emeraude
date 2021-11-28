﻿using System;
using System.Threading.Tasks;
using Emeraude.Application.Exceptions;
using Emeraude.Application.Identity.Requests.Commands.ForgotPassword;
using Emeraude.Infrastructure.Localization.Attributes;
using Emeraude.Presentation.Extensions;
using Emeraude.Presentation.PlatformBase.Extensions;
using Emeraude.Presentation.PlatformBase.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Emeraude.Presentation.PlatformBase.Controllers
{
    /// <inheritdoc cref="UserAuthenticationController"/>
    public abstract partial class UserAuthenticationController
    {
        private const string ForgotPasswordRoute = "/forgot-password";

        /// <summary>
        /// Forgot password action for GET request.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route(ForgotPasswordRoute)]
        [LanguageRoute(ForgotPasswordRoute)]
        public virtual IActionResult ForgotPassword()
        {
            if (this.IsAuthenticated)
            {
                return this.RedirectToDefault();
            }

            var viewModel = new ForgotPasswordViewModel();

            return this.ForgotPasswordView(viewModel);
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
        public virtual async Task<IActionResult> ForgotPassword(ForgotPasswordCommand request)
        {
            if (this.IsAuthenticated)
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

            return this.ForgotPasswordView(request as ForgotPasswordViewModel);
        }

        private ViewResult ForgotPasswordView(ForgotPasswordViewModel model)
        {
            return this.View("ForgotPassword", model);
        }
    }
}