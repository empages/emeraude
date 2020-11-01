using System;
using System.Threading.Tasks;
using Definux.Emeraude.Application.Exceptions;
using Definux.Emeraude.Application.Requests.Identity.Commands.ForgotPassword;
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
                return this.RedirectToHomeIndex();
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
                return this.RedirectToHomeIndex();
            }

            try
            {
                var result = await this.Mediator.Send(request);
                if (result.Successed)
                {
                    return this.ForgotPasswordSuccessView(request);
                }
                else
                {
                    await this.Logger.LogErrorAsync(new ArgumentException($"Invalid email ({request.Email}) from reset password form."));
                    return this.ForgotPasswordSuccessView(request);
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

            return this.ForgotPasswordView(request);
        }

        private ViewResult ForgotPasswordView(object model)
        {
            return this.View("ForgotPassword", model);
        }

        private ViewResult ForgotPasswordSuccessView(object model)
        {
            return this.View("ForgotPasswordSuccess", model);
        }
    }
}
