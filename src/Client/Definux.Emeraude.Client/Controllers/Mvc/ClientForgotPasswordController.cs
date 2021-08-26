using System;
using System.Threading.Tasks;
using Definux.Emeraude.Application.Exceptions;
using Definux.Emeraude.Application.Requests.Identity.Commands.ForgotPassword;
using Definux.Emeraude.Client.Attributes;
using Definux.Emeraude.Client.Models;
using Definux.Emeraude.Locales.Attributes;
using Definux.Emeraude.Presentation.Extensions;
using Definux.Emeraude.Resources;
using Microsoft.AspNetCore.Mvc;

namespace Definux.Emeraude.Client.Controllers.Mvc
{
    /// <inheritdoc/>
    public sealed partial class ClientAuthenticationController : ClientController
    {
        private const string ForgotPasswordRoute = "/forgot-password";
        private const string ForgotPasswordTitle = "FORGOT_PASSWORD_PAGE_TITLE";
        private const string ForgotPasswordDescription = "FORGOT_PASSWORD_PAGE_DESCRIPTION";

        /// <summary>
        /// Forgot password action for GET request.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route(ForgotPasswordRoute)]
        [LanguageRoute(ForgotPasswordRoute)]
        [MetaTag(MainMetaTags.Title, ForgotPasswordTitle, true)]
        [MetaTag(MainMetaTags.Description, ForgotPasswordDescription, true)]
        [Canonical]
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
        [MetaTag(MainMetaTags.Title, ForgotPasswordTitle, true)]
        [MetaTag(MainMetaTags.Description, ForgotPasswordDescription, true)]
        [Canonical]
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
                    await this.Logger.LogErrorAsync(new ArgumentException($"Invalid email ({request.Email}) from reset password form."));
                }

                return await this.RedirectToSucceededExecutionResultAsync(
                    Titles.ForgotPasswordSuccess,
                    Messages.ForgotPasswordSuccessMessage,
                    "forgot-password");
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
    }
}
