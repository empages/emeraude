using Definux.Emeraude.Application.Common.Exceptions;
using Definux.Emeraude.Application.Requests.Identity.Commands.Register;
using Definux.Emeraude.Presentation.Controllers;
using Definux.Emeraude.Presentation.Extensions;
using Definux.Emeraude.Resources;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Definux.Emeraude.Client.Controllers.Api
{
    public partial class ClientApiAuthenticationController : ApiController
    {
        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register([FromBody]RegisterRequest request)
        {
            if (User.Identity.IsAuthenticated)
            {
                return BadRequest();
            }

            try
            {
                var requestResult = await Mediator.Send(new RegisterCommand(request));

                if (requestResult.Result.Succeeded)
                {
                    return Ok();
                }
                else
                {
                    ModelState.AddModelError(string.Empty, Messages.UserCannotBeRegistered);
                }
            }
            catch (ValidationException ex)
            {
                ModelState.ApplyValidationException(ex);
            }
            catch (Exception)
            {
                ModelState.AddModelError(string.Empty, Messages.UserCannotBeRegistered);
            }

            return this.BadRequestWithModelErrors();
        }
    }
}
