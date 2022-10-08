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
    [EmPortalEndpoint("identity.auth.login")]
    [Route("auth/login")]
    [HttpPost]
    public async Task<IActionResult> AuthLogin()
    {
        return this.Ok();
    }

    /// <summary>
    /// Login to the application with second factor.
    /// </summary>
    /// <returns></returns>
    [EmPortalEndpoint("identity.auth.login.mfa")]
    [Route("auth/login-mfa")]
    [HttpPost]
    public async Task<IActionResult> AuthLoginMfa()
    {
        return this.Ok();
    }
}