using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EmPages.PortalGateway.Controllers;

/// <summary>
/// Gateway identity controller.
/// </summary>
[Route($"{EmPortalGatewayConstants.RoutePrefix}/identity/")]
public class EmIdentityController : EmPortalGatewayController
{
    /// <summary>
    /// Login to the application.
    /// </summary>
    /// <returns></returns>
    [HttpPost("auth/login")]
    public async Task<IActionResult> AuthLogin()
    {
        return this.Ok();
    }

    /// <summary>
    /// Login to the application with second factor.
    /// </summary>
    /// <returns></returns>
    [HttpPost("auth/login-mfa")]
    public async Task<IActionResult> AuthLoginMfa()
    {
        return this.Ok();
    }
}