using System;
using System.Threading.Tasks;
using Definux.Emeraude.Locales.Attributes;
using Definux.Utilities.Objects;
using Emeraude.Application.Identity.Requests.Commands.ChangeEmail;
using Emeraude.Essentials.Base;
using Emeraude.Presentation.Controllers;
using Emeraude.Presentation.PlatformBase.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Emeraude.Presentation.PlatformBase.Controllers
{
    /// <summary>
    /// Client controller for MVC user management.
    /// </summary>
    [Authorize(AuthenticationSchemes = EmAuthenticationDefaults.CookieAuthenticationScheme)]
    public abstract class UserManagementController : PublicController
    {
        private const string ChangeEmailRoute = "/confirm-change-email";

        private readonly ILogger<UserManagementController> logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserManagementController"/> class.
        /// </summary>
        /// <param name="logger"></param>
        protected UserManagementController(ILogger<UserManagementController> logger)
        {
            this.logger = logger;
        }

        /// <summary>
        /// Confirms change email request.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        [HttpGet]
        [Route(ChangeEmailRoute)]
        [LanguageRoute(ChangeEmailRoute)]
        public virtual async Task<IActionResult> ConfirmChangeEmail(
            [FromQuery]string email,
            [FromQuery]string token)
        {
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrEmpty(token))
            {
                return this.NotFound();
            }

            var result = SimpleResult.UnsuccessfulResult;

            try
            {
                result = await this.Mediator.Send(new ChangeEmailCommand(email, token));
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex, "An error occured during change email confirmation action");
            }

            return await this.RedirectToExecutionResultAsync(
                result.Succeeded,
                Strings.SuccessfulChangeEmailConfirmation,
                Strings.ChangeEmailConfirmationFailed,
                Strings.ChangeEmailAddressConfirmationHasBeenSuccessful,
                Strings.ChangeEmailAddressConfirmationHasBeenFailed,
                "change-email");
        }
    }
}