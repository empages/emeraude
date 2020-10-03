using System;
using System.Threading.Tasks;
using Definux.Emeraude.Application.Common.Exceptions;
using Definux.Emeraude.Application.Requests.Identity.Commands.Login;
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
        /// Login action.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody]LoginRequest request)
        {
            if (this.User.Identity.IsAuthenticated)
            {
                return this.BadRequest();
            }

            try
            {
                var requestResult = await this.Mediator.Send(new LoginCommand(request));

                if (requestResult.Result.Succeeded)
                {
                    var tokenResult = await this.userTokensService.BuildJwtTokenForUserAsync(requestResult.User.Id);
                    return this.Ok(tokenResult);
                }
                else if (requestResult.Result.IsLockedOut)
                {
                    this.ModelState.AddModelError(string.Empty, Messages.YourProfileIsTemporaryLockedOut);
                }
                else
                {
                    this.ModelState.AddModelError(string.Empty, Messages.YourEmailOrPasswordIsIncorrect);
                }
            }
            catch (ValidationException ex)
            {
                this.ModelState.ApplyValidationException(ex);
            }
            catch (Exception)
            {
                this.ModelState.AddModelError(string.Empty, Messages.YourLoginAttemptHasFailed);
            }

            return this.BadRequestWithModelErrors();
        }
    }
}
