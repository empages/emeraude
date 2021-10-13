using System;
using System.Threading.Tasks;
using Definux.Emeraude.Application.Requests.Identity.Commands.ConfirmEmail;
using Definux.Emeraude.Locales.Attributes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Definux.Emeraude.Client.Controllers.Mvc
{
    /// <inheritdoc/>
    public sealed partial class ClientAuthenticationController : ClientController
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
        public async Task<IActionResult> ConfirmEmail([FromQuery]string email, [FromQuery]string token)
        {
            if (this.User.Identity.IsAuthenticated)
            {
                return this.RedirectToDefault();
            }

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrEmpty(token))
            {
                return this.NotFound();
            }

            ConfirmEmailRequestResult requestResult = new ConfirmEmailRequestResult(false);

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
