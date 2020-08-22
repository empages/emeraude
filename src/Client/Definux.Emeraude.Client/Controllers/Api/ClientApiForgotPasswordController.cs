using Definux.Emeraude.Application.Common.Exceptions;
using Definux.Emeraude.Application.Requests.Identity.Commands.ForgotPassword;
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
        [Route("forgot-password")]
        public async Task<IActionResult> ForgotPassword([FromBody]ForgotPasswordRequest request)
        {
            if (User.Identity.IsAuthenticated)
            {
                return BadRequest();
            }

            try
            {
                var requestResult = await Mediator.Send(new ForgotPasswordCommand(request));

                if (requestResult.Successed)
                {
                    return Ok();
                }
                else
                {
                    await Logger.LogErrorAsync(new ArgumentException($"Invalid email ({request.Email}) from reset password form."));
                    return Ok();
                }
            }
            catch (ValidationException ex)
            {
                ModelState.ApplyValidationException(ex);
            }
            catch (Exception)
            {
                ModelState.AddModelError(string.Empty, Messages.YourRequestCannotBeExecuted);
            }

            return this.BadRequestWithModelErrors();
        }
    }
}
