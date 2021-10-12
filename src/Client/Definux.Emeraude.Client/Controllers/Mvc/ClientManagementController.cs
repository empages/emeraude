using System;
using System.Threading.Tasks;
using Definux.Emeraude.Application.Requests.Identity.Commands.ChangeEmail;
using Definux.Emeraude.Configuration.Authorization;
using Definux.Emeraude.Locales.Attributes;
using Definux.Emeraude.Resources;
using Definux.Utilities.Objects;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Definux.Emeraude.Client.Controllers.Mvc
{
    /// <summary>
    /// Client controller for MVC user management.
    /// </summary>
    [Authorize(AuthenticationSchemes = AuthenticationDefaults.ClientAuthenticationScheme)]
    public class ClientManagementController : ClientController
    {
        private const string ChangeEmailRoute = "/confirm-change-email";

        private readonly ILogger<ClientManagementController> logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientManagementController"/> class.
        /// </summary>
        /// <param name="logger"></param>
        public ClientManagementController(ILogger<ClientManagementController> logger)
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
        public async Task<IActionResult> ConfirmChangeEmail(
            [FromQuery]string email,
            [FromQuery]string token)
        {
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrEmpty(token))
            {
                return this.NotFound();
            }

            var requestResult = SimpleResult.UnsuccessfulResult;

            try
            {
                requestResult = await this.Mediator.Send(new ChangeEmailCommand(email, token));
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex, "An error occured during change email confirmation action");
            }

            return await this.RedirectToExecutionResultAsync(
                requestResult.Succeeded,
                Titles.ChangeEmailSuccess,
                Titles.ChangeEmailFailed,
                Messages.ChangedEmailSuccessMessage,
                Messages.ChangedEmailFailedMessage,
                "change-email");
        }
    }
}