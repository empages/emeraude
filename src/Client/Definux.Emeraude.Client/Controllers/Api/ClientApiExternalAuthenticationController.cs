using System;
using System.Threading.Tasks;
using Definux.Emeraude.Application.Requests.Identity.Commands.ExternalAuthentication;
using Definux.Emeraude.Presentation.Controllers;
using Definux.Emeraude.Presentation.Extensions;
using Definux.Emeraude.Resources;
using Microsoft.AspNetCore.Mvc;

namespace Definux.Emeraude.Client.Controllers.Api
{
    /// <inheritdoc/>
    public sealed partial class ClientApiAuthenticationController : ApiController
    {
        /// <summary>
        /// External login provider authentication action.
        /// </summary>
        /// <param name="authData"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("external")]
        public async Task<IActionResult> ExternalAuthentication([FromBody]ExternalAuthenticationData authData)
        {
            if (this.User.Identity.IsAuthenticated)
            {
                return this.BadRequest();
            }

            try
            {
                var requestResult = await this.Mediator.Send(new ExternalAuthenticationCommand(authData));

                if (requestResult.Result.Succeeded)
                {
                    var tokenResult = await this.userTokensService.BuildJwtTokenForUserAsync(requestResult.User.Id);
                    return this.Ok(tokenResult);
                }
                else
                {
                    this.ModelState.AddModelError(string.Empty, Messages.YourRequestCannotBeExecuted);
                }
            }
            catch (Exception)
            {
                this.ModelState.AddModelError(string.Empty, Messages.YourRequestCannotBeExecuted);
            }

            return this.BadRequestWithModelErrors();
        }
    }
}
