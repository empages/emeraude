using System;
using System.Threading.Tasks;
using Emeraude.Application.Identity.Requests.Commands.ConfirmEmail;
using Emeraude.Infrastructure.Localization.Attributes;
using Emeraude.Presentation.PlatformBase.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Emeraude.Presentation.PlatformBase.Controllers
{
    /// <inheritdoc cref="UserAuthenticationController"/>
    public abstract partial class UserAuthenticationController
    {
        private const string ConfirmEmailRoute = "/confirm-email";

        /// <summary>
        /// Confirm email action.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        [HttpGet]
        [Route(ConfirmEmailRoute)]
        [LanguageRoute(ConfirmEmailRoute)]
        public virtual async Task<IActionResult> ConfirmEmail([FromQuery]string email, [FromQuery]string token)
        {
            if (this.IsAuthenticated)
            {
                return this.RedirectToDefault();
            }

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrEmpty(token))
            {
                return this.NotFound();
            }

            var requestResult = new ConfirmEmailRequestResult(false);

            try
            {
                requestResult = await this.Mediator.Send(new ConfirmEmailCommand(email, token));
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex, "An error occured during confirm email action");
            }

            return await this.RedirectToExecutionResultAsync(
                requestResult.Succeeded,
                Strings.SuccessfulEmailConfirmation,
                Strings.EmailConfirmationFailed,
                Strings.EmailAddressConfirmationHasBeenSuccessful,
                Strings.EmailAddressConfirmationHasBeenFailed,
                "confirm-email");
        }
    }
}
