using Definux.Emeraude.Application.Requests.Identity.Commands.ExternalAuthentication;
using Definux.Emeraude.Presentation.Controllers;
using Definux.Emeraude.Presentation.Extensions;
using Definux.Emeraude.Resources;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Definux.Emeraude.Client.Controllers.Api
{
    public partial class ClientApiAuthenticationController : ApiController
    {
        [HttpPost]
        [Route("external")]
        public async Task<IActionResult> ExternalAuthentication([FromBody]ExternalAuthenticationData authData)
        {
            if (User.Identity.IsAuthenticated)
            {
                return BadRequest();
            }

            try
            {
                var requestResult = await Mediator.Send(new ExternalAuthenticationCommand(authData));

                if (requestResult.Result.Succeeded)
                {
                    var tokenResult = await this.userTokensService.BuildJwtTokenForUserAsync(requestResult.User.Id);
                    return Ok(tokenResult);
                }
                else
                {
                    ModelState.AddModelError(string.Empty, Messages.YourRequestCannotBeExecuted);
                }
            }
            catch (Exception)
            {
                ModelState.AddModelError(string.Empty, Messages.YourRequestCannotBeExecuted);
            }

            return this.BadRequestWithModelErrors();
        }
    }
}
