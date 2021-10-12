using System;
using System.Threading.Tasks;
using Definux.Emeraude.Application.Requests.Identity.Commands.ExternalAuthentication;
using Definux.Emeraude.Client.Extensions;
using Definux.Emeraude.Identity.Extensions;
using Definux.Emeraude.Presentation.Controllers;
using Definux.Emeraude.Presentation.Extensions;
using Definux.Emeraude.Resources;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Definux.Emeraude.Client.Controllers.Api
{
    /// <inheritdoc/>
    public sealed partial class ClientAuthenticationApiController : EmApiController
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
            if (!this.OptionsProvider.GetIdentityOptions().HasExternalAuthentication)
            {
                return this.NotFound();
            }

            if (this.User.Identity.IsAuthenticated)
            {
                return this.BadRequest();
            }

            if (!this.externalProviderAuthenticatorFactory.ContainsProvider(authData?.Provider))
            {
                return this.NotFound();
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
            catch (Exception ex)
            {
                this.logger.LogError(ex, "An error occured during external authentication");
                this.ModelState.AddModelError(string.Empty, Messages.YourRequestCannotBeExecuted);
            }

            return this.BadRequestWithModelErrors();
        }
    }
}
