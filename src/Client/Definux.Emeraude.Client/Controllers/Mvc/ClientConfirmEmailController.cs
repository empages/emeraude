using System;
using System.Threading.Tasks;
using Definux.Emeraude.Application.Requests.Identity.Commands.ConfirmEmail;
using Definux.Emeraude.Client.Attributes;
using Definux.Emeraude.Client.Models;
using Definux.Emeraude.Locales.Attributes;
using Definux.Emeraude.Resources;
using Microsoft.AspNetCore.Mvc;

namespace Definux.Emeraude.Client.Controllers.Mvc
{
    /// <inheritdoc/>
    public sealed partial class ClientAuthenticationController : ClientController
    {
        private const string ConfirmEmailRoute = "/confirm-email";
        private const string ConfirmEmailTitle = "CONFIRM_EMAIL_PAGE_TITLE";
        private const string ConfirmEmailDescription = "CONFIRM_EMAIL_PAGE_DESCRIPTION";

        /// <summary>
        /// Confirm email action.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        [HttpGet]
        [Route(ConfirmEmailRoute)]
        [LanguageRoute(ConfirmEmailRoute)]
        [MetaTag(MainMetaTags.Title, ConfirmEmailTitle, true)]
        [MetaTag(MainMetaTags.Description, ConfirmEmailDescription, true)]
        [Canonical]
        public async Task<IActionResult> ConfirmEmail([FromQuery]string email, [FromQuery]string token)
        {
            if (this.User.Identity.IsAuthenticated)
            {
                return this.RedirectToHomeIndex();
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
                await this.Logger.LogErrorAsync(ex);
            }

            return await this.RedirectToExecutionResultAsync(
                requestResult.Succeeded,
                Titles.ConfirmEmailSuccess,
                Titles.ConfirmEmailFailed,
                Messages.ConfirmedEmailSuccecssMessage,
                Messages.ConfirmedEmailFailedMessage,
                "confirm-email");
        }
    }
}
