using System;
using System.Threading.Tasks;
using Definux.Emeraude.Application.Common.Exceptions;
using Definux.Emeraude.Application.Requests.Identity.Commands.ForgotPassword;
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
        /// Forgot password action.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("forgot-password")]
        public async Task<IActionResult> ForgotPassword([FromBody]ForgotPasswordRequest request)
        {
            if (this.User.Identity.IsAuthenticated)
            {
                return this.BadRequest();
            }

            try
            {
                var requestResult = await this.Mediator.Send(new ForgotPasswordCommand(request));

                if (requestResult.Successed)
                {
                    return this.Ok();
                }
                else
                {
                    await this.Logger.LogErrorAsync(new ArgumentException($"Invalid email ({request.Email}) from reset password form."));
                    return this.Ok();
                }
            }
            catch (ValidationException ex)
            {
                this.ModelState.ApplyValidationException(ex);
            }
            catch (Exception)
            {
                this.ModelState.AddModelError(string.Empty, Messages.YourRequestCannotBeExecuted);
            }

            return this.BadRequestWithModelErrors();
        }
    }
}
