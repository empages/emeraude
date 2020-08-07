using Definux.Emeraude.Application.Common.Exceptions;
using Definux.Emeraude.Application.Requests.Identity.Commands.Login;
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
        [Route("login")]
        public async Task<IActionResult> Login([FromBody]LoginRequest request)
        {
            if (User.Identity.IsAuthenticated)
            {
                return BadRequest();
            }

            try
            {
                var requestResult = await Mediator.Send(new LoginCommand(request));

                if (requestResult.Result.Succeeded)
                {
                    var tokenResult = await this.userTokensService.BuildJwtTokenForUserAsync(requestResult.User.Id);
                    return Ok(tokenResult);
                }
                else if (requestResult.Result.IsLockedOut)
                {
                    ModelState.AddModelError(string.Empty, Messages.YourProfileIsTemporaryLockedOut);
                }
                else
                {
                    ModelState.AddModelError(string.Empty, Messages.YourEmailOrPasswordIsIncorrect);
                }
            }
            catch (ValidationException ex)
            {
                ModelState.ApplyValidationException(ex);
            }
            catch (Exception)
            {
                ModelState.AddModelError(string.Empty, Messages.YourLoginAttemptHasFailed);
            }

            return this.BadRequestWithModelErrors();
        }
    }
}
