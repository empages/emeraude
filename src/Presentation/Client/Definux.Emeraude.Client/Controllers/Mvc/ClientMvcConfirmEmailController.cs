using Definux.Emeraude.Application.Requests.Identity.Commands.ConfirmEmail;
using Definux.Emeraude.Locales.Attributes;
using Definux.Emeraude.Presentation.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Definux.Emeraude.Client.Controllers.Mvc
{
    public partial class ClientMvcAuthenticationController : PublicController
    {
        public const string ConfirmEmailRoute = "/confirm-email";

        [HttpGet]
        [Route(ConfirmEmailRoute)]
        [LanguageRoute(ConfirmEmailRoute)]
        public async Task<IActionResult> ConfirmEmail([FromQuery]string email, [FromQuery]string token)
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToHomeIndex();
            }

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrEmpty(token))
            {
                return NotFound();
            }

            ConfirmEmailRequestResult requestResult = new ConfirmEmailRequestResult(false);

            try
            {
                requestResult = await Mediator.Send(new ConfirmEmailCommand(email, token));
            }
            catch (Exception ex)
            {
                await Logger.LogErrorAsync(ex);
            }

            return ConfirmEmailView(requestResult);
        }

        public ViewResult ConfirmEmailView(object model)
        {
            return View("ConfirmEmail", model);
        }
    }
}
