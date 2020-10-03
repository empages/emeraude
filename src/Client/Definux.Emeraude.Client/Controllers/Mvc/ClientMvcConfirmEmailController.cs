using System;
using System.Threading.Tasks;
using Definux.Emeraude.Application.Requests.Identity.Commands.ConfirmEmail;
using Definux.Emeraude.Locales.Attributes;
using Definux.Emeraude.Presentation.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Definux.Emeraude.Client.Controllers.Mvc
{
    /// <inheritdoc/>
    public sealed partial class ClientMvcAuthenticationController : PublicController
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

            return this.ConfirmEmailView(requestResult);
        }

        private ViewResult ConfirmEmailView(object model)
        {
            return this.View("ConfirmEmailSuccess", model);
        }
    }
}
