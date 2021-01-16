using System.Threading.Tasks;
using Definux.Emeraude.Admin.ClientBuilder.DataAnnotations;
using Definux.Emeraude.Application.Logger;
using Definux.Emeraude.Application.Requests.Logging.Commands.LogFrontEndError;
using Definux.Emeraude.Presentation.Controllers;
using Definux.Utilities.Objects;
using Microsoft.AspNetCore.Mvc;

namespace Definux.Emeraude.Controllers.Api
{
    /// <summary>
    /// Client API logger controller.
    /// </summary>
    [Route("/api/logger/")]
    [ApiEndpointsController]
    public class LoggerApiController : ApiController
    {
        private readonly IEmLogger logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="LoggerApiController"/> class.
        /// </summary>
        /// <param name="logger"></param>
        public LoggerApiController(IEmLogger logger)
        {
            this.logger = logger;
        }

        /// <summary>
        /// Log error to server.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("error")]
        [Endpoint(typeof(SimpleResult))]
        public async Task<IActionResult> LogClientError([FromBody]LogFrontEndErrorCommand request)
        {
            return this.Ok(await this.Mediator.Send(request));
        }
    }
}