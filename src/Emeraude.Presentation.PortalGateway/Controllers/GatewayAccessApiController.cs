using Emeraude.Essentials.Base;
using Emeraude.Presentation.PortalGateway.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace Emeraude.Presentation.PortalGateway.Controllers
{
    /// <summary>
    /// Portal Gateway access controller.
    /// </summary>
    [Route("/_em/api/access")]
    public class GatewayAccessApiController : EmPortalGatewayApiController
    {
        private readonly IWebHostEnvironment hostEnvironment;

        /// <summary>
        /// Initializes a new instance of the <see cref="GatewayAccessApiController"/> class.
        /// </summary>
        /// <param name="hostEnvironment"></param>
        public GatewayAccessApiController(IWebHostEnvironment hostEnvironment)
        {
            this.hostEnvironment = hostEnvironment;
        }

        /// <summary>
        /// Verifies the existence of portal access to the current application gateway.
        /// </summary>
        /// <returns></returns>
        [HttpPost("verify")]
        public IActionResult VerifyPortalAccess()
        {
            var response = new GatewayResponse
            {
                Verified = true,
                Environment = this.hostEnvironment.EnvironmentName,
            };

            return this.Ok(response);
        }
    }
}