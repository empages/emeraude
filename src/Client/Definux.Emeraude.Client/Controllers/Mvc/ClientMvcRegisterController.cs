using System;
using System.Threading.Tasks;
using Definux.Emeraude.Application.Exceptions;
using Definux.Emeraude.Application.Requests.Identity.Commands.Register;
using Definux.Emeraude.Locales.Attributes;
using Definux.Emeraude.Presentation.Controllers;
using Definux.Emeraude.Presentation.Extensions;
using Definux.Emeraude.Resources;
using Definux.Seo.Attributes;
using Definux.Seo.Models;
using Microsoft.AspNetCore.Mvc;

namespace Definux.Emeraude.Client.Controllers.Mvc
{
    /// <inheritdoc/>
    public sealed partial class ClientMvcAuthenticationController : ClientController
    {
        private const string RegisterRoute = "/register";
        private const string RegisterTitle = "REGISTER_PAGE_TITLE";
        private const string RegisterDescription = "REGISTER_PAGE_DESCRIPTION";

        /// <summary>
        /// Register action for GET request.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route(RegisterRoute)]
        [LanguageRoute(RegisterRoute)]
        [MetaTag(MainMetaTags.Title, RegisterTitle, true)]
        [MetaTag(MainMetaTags.Description, RegisterDescription, true)]
        public IActionResult Register()
        {
            if (this.User.Identity.IsAuthenticated)
            {
                return this.RedirectToHomeIndex();
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
        [MetaTag(MainMetaTags.Title, RegisterTitle, true)]
        [MetaTag(MainMetaTags.Description, RegisterDescription, true)]
        public async Task<IActionResult> Register(RegisterCommand request)
        {
            if (this.User.Identity.IsAuthenticated)
            {
                return this.RedirectToHomeIndex();
            }

            try
            {
                var requestResult = await this.Mediator.Send(request);

                if (requestResult.Result.Succeeded)
                {
                    return await this.RedirectToSucceededExecutionResultAsync(
                        Titles.RegisterSuccess,
                        Messages.RegistrationSuccessMessage,
                        "register");
                }
                else
                {
                    this.ModelState.AddModelError(string.Empty, Messages.UserCannotBeRegistered);
                }
            }
            catch (ValidationException ex)
            {
                this.ModelState.ApplyValidationException(ex);
            }
            catch (Exception)
            {
                this.ModelState.AddModelError(string.Empty, Messages.UserCannotBeRegistered);
            }

            return this.RegisterView(request);
        }

        private ViewResult RegisterView(object model)
        {
            return this.View("Register", model);
        }
    }
}
