using System.Threading.Tasks;
using EmPages.Common;
using EmPages.Portal.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace EmPages.Portal.Controllers;

/// <summary>
/// Controller that provides connectivity resources.
/// </summary>
[Route($"{EmPortalConstants.RouteApiPrefix}/state/")]
public class EmStateApiController : EmPortalApiController
{
    private readonly IWebHostEnvironment hostEnvironment;

    /// <summary>
    /// Initializes a new instance of the <see cref="EmStateApiController"/> class.
    /// </summary>
    /// <param name="hostEnvironment"></param>
    public EmStateApiController(IWebHostEnvironment hostEnvironment)
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
        this.Ok(new EmPortalState
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