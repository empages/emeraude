using System.Threading.Tasks;
using EmPages.Common;
using EmPages.PortalGateway.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace EmPages.PortalGateway.Controllers;

/// <summary>
/// Controller that provides connectivity resources.
/// </summary>
[Route($"{EmPortalGatewayConstants.RoutePrefix}/state/")]
public class EmStateController : EmPortalGatewayController
{
    private readonly IWebHostEnvironment hostEnvironment;

    /// <summary>
    /// Initializes a new instance of the <see cref="EmStateController"/> class.
    /// </summary>
    /// <param name="hostEnvironment"></param>
    public EmStateController(IWebHostEnvironment hostEnvironment)
    {
        this.hostEnvironment = hostEnvironment;
    }

    /// <summary>
    /// Returns state of the current instance of portal gateway.
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    [AllowAnonymous]
    public IActionResult GetState() =>
        this.Ok(new EmPortalGatewayState
        {
            Framework = EmConstants.FrameworkName,
            Version = this.GetType()?.Assembly?.GetName()?.Version?.ToString(),
            Environment = this.hostEnvironment.EnvironmentName,
        });

    /// <summary>
    /// Checks whether request to gateway is made by authorized user or not.
    /// </summary>
    /// <returns></returns>
    [HttpGet("auth")]
    public IActionResult CheckAuthState() =>
        this.Ok();
}