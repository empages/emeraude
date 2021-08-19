using Definux.Emeraude.Presentation.Controllers;
using Definux.Utilities.Objects;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Definux.Emeraude.Presentation.Attributes;
using EmDoggo.Application.Requests.Commands.ComplexRequest;

namespace EmDoggo.Controllers.Api
{
    [Route("/api/empty/")]
    [ApiEndpointsController]
    public class EmptyApiController : ApiController
    {
        [HttpGet]
        [Route("example")]
        [Endpoint(typeof(SimpleResult))]
        public async Task<IActionResult> ExampleAction()
        {
            return Ok(SimpleResult.SuccessfulResult);
        }

        [HttpPost]
        [Route("complex")]
        [Endpoint(typeof(ComplexRequestResult))]
        public async Task<IActionResult> ComplexRequestTypeAction([FromBody]ComplexRequestCommand request)
        {
            return Ok(await Mediator.Send(request));
        }
    }
}
