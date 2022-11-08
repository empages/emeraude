using System.Threading.Tasks;
using EmPages.Identity;
using EmPages.PortalGateway.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmPages.PortalGateway.Controllers;

/// <summary>
/// Gateway identity controller.
/// </summary>
[Route($"{EmPortalGatewayConstants.RoutePrefix}/identity/")]
public class EmIdentityController : EmPortalGatewayController
{
    private readonly IEmIdentityService identityService;

    /// <summary>
    /// Initializes a new instance of the <see cref="EmIdentityController"/> class.
    /// </summary>
    /// <param name="identityService"></param>
    public EmIdentityController(IEmIdentityService identityService)
    {
        this.identityService = identityService;
    }

    /// <summary>
    /// Login to the application.
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    [EmPortalEndpoint(EmPortalGatewayEndpointsIds.IdentityAuthLogin)]
    [Route("auth/login")]
    [HttpPost]
    public async Task<IActionResult> AuthLogin([FromBody]EmTokenBaseCredentialsRequest request)
    {
        if (this.User?.Identity?.IsAuthenticated ?? true)
        {
            return this.BadRequest();
        }

        if (!this.ModelState.IsValid)
        {
            return this.BadRequest(this.ModelState);
        }

        var result = await this.identityService.RetrieveAccessTokenAsync(request);
        return this.Ok(result);
    }

    /// <summary>
    /// Login to the application with second factor.
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    [EmPortalEndpoint(EmPortalGatewayEndpointsIds.IdentityAuthLoginMfa)]
    [Route("auth/login-mfa")]
    [HttpPost]
    public async Task<IActionResult> AuthLoginMfa([FromBody]EmTokenBaseCredentialsRequest request)
    {
        if (this.User?.Identity?.IsAuthenticated ?? true)
        {
            return this.BadRequest();
        }

        if (!this.ModelState.IsValid)
        {
            return this.BadRequest(this.ModelState);
        }

        var result = await this.identityService.RetrieveAccessTokenAsync(request);
        return this.Ok(result);
    }

    /// <summary>
    /// Changes the password for current user.
    /// </summary>
    /// <returns></returns>
    [EmPortalEndpoint(EmPortalGatewayEndpointsIds.IdentityManageChangePassword)]
    [Route("manage/change-password")]
    [HttpPost]
    public async Task<IActionResult> ManageChangePassword()
    {
        return this.Ok();
    }

    /// <summary>
    /// Changes the email for current user.
    /// </summary>
    /// <returns></returns>
    [EmPortalEndpoint(EmPortalGatewayEndpointsIds.IdentityManageChangeEmail)]
    [Route("manage/change-email")]
    [HttpPost]
    public async Task<IActionResult> ManageChangeEmail()
    {
        return this.Ok();
    }

    /// <summary>
    /// Retrieves the MFA description.
    /// </summary>
    /// <returns></returns>
    [EmPortalEndpoint(EmPortalGatewayEndpointsIds.IdentityManageMfaDescription)]
    [Route("manage/mfa-description")]
    [HttpPost]
    public async Task<IActionResult> ManageMfaDescription()
    {
        return this.Ok();
    }

    /// <summary>
    /// Activates the MFA.
    /// </summary>
    /// <returns></returns>
    [EmPortalEndpoint(EmPortalGatewayEndpointsIds.IdentityManageMfaActivate)]
    [Route("manage/mfa-activate")]
    [HttpPost]
    public async Task<IActionResult> ManageMfaActivate()
    {
        return this.Ok();
    }

    /// <summary>
    /// Reset the MFA.
    /// </summary>
    /// <returns></returns>
    [EmPortalEndpoint(EmPortalGatewayEndpointsIds.IdentityManageMfaReset)]
    [Route("manage/mfa-reset")]
    [HttpPost]
    public async Task<IActionResult> ManageMfaReset()
    {
        return this.Ok();
    }
}