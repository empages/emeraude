using System.Reflection;
using Emeraude.Presentation.PortalGateway.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

namespace Emeraude.Presentation.PortalGateway.Controllers;

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
            FrameworkVersion = Assembly.GetExecutingAssembly().GetName()?.Version?.ToString() ?? "0.0.0",
            IsDevelopment = this.hostEnvironment.IsDevelopment(),
        };

        return this.Ok(response);
    }
}