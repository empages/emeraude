using Definux.Emeraude.Admin.ClientBuilder.DataAnnotations;
using Definux.Emeraude.Configuration.Authorization;
using Definux.Emeraude.Presentation.Controllers;
using EmDoggo.Application.Requests.Commands.AddDog;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EmDoggo.Controllers.Api
{
    [Route("/api/dogs/")]
    [ApiEndpointsController]
    [Authorize(AuthenticationSchemes = AuthenticationDefaults.ClientAuthenticationScheme)]
    public class DogsApiController : ApiController
    {
        [HttpPost]
        [Route("add")]
        [Endpoint(typeof(Definux.Utilities.Objects.CreatedResult))]
        public async Task<IActionResult> AddDog([FromBody]AddDogCommand request, [FromQuery(Name = "someQuery"), IgnoreParam]string someQuery)
        {
            return Ok(await Mediator.Send(request));
        }
    }
}
