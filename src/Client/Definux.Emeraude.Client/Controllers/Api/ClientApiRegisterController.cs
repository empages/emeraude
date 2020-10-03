using System;
using System.Linq;
using System.Threading.Tasks;
using Definux.Emeraude.Application.Common.Exceptions;
using Definux.Emeraude.Application.Requests.Identity.Commands.Register;
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
        /// Register action.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register([FromBody]RegisterRequest request)
        {
            if (this.User.Identity.IsAuthenticated)
            {
                return this.BadRequest();
            }

            try
            {
                var requestResult = await this.Mediator.Send(new RegisterCommand(request));

                if (requestResult.Result.Succeeded)
                {
                    return this.Ok();
                }
                else
                {
                    this.ModelState.AddModelError(string.Empty, Messages.UserCannotBeRegistered);
                }
            }
            catch (ValidationException ex)
            {
                this.ModelState.ApplyValidationException(ex);
            }
            catch (Exception)
            {
                this.ModelState.AddModelError(string.Empty, Messages.UserCannotBeRegistered);
            }

            return this.BadRequestWithModelErrors();
        }
    }
}
