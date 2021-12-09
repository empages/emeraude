using System.Threading.Tasks;
using Emeraude.Application.Identity.Requests.Commands.ActivateTwoFactorAuthentication;
using Emeraude.Infrastructure.Identity.Common;
using Emeraude.Infrastructure.Identity.TokenProviders;
using Emeraude.Presentation.PortalGateway.Models;
using Emeraude.Presentation.PortalGateway.Strategies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Emeraude.Presentation.PortalGateway.Controllers.Admin;

/// <summary>
/// Admin identity API controller.
/// </summary>
[Route("/_em/api/admin/identity/")]
[Authorize(Policy = EmPermissions.AccessAdministrationPolicy)]
public class AdminIdentityApiController : EmPortalGatewayApiController
{
    private readonly IAuthenticationActionsStrategy authenticationActionsStrategy;
    private readonly IManageActionsStrategy manageActionsStrategy;

    /// <summary>
    /// Initializes a new instance of the <see cref="AdminIdentityApiController"/> class.
    /// </summary>
    /// <param name="authenticationActionsStrategy"></param>
    /// <param name="manageActionsStrategy"></param>
    public AdminIdentityApiController(
        IAuthenticationActionsStrategy authenticationActionsStrategy,
        IManageActionsStrategy manageActionsStrategy)
    {
        this.authenticationActionsStrategy = authenticationActionsStrategy;
        this.manageActionsStrategy = manageActionsStrategy;
    }

    /// <summary>
    /// Login action.
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    [HttpPost("auth/login")]
    [AllowAnonymous]
    public virtual async Task<IActionResult> Login([FromBody]AdminAuthLoginRequest request) =>
        await this.authenticationActionsStrategy.LoginAsync(this, request);

    /// <summary>
    /// Login with second factor.
    /// </summary>
    /// <param name="postAuthenticationToken"></param>
    /// <param name="request"></param>
    /// <returns></returns>
    [HttpPost("auth/login-2fa")]
    [AllowAnonymous]
    public virtual async Task<IActionResult> LoginWithTwoFactorAuthenticator(
        [FromHeader(Name = EmPostAuthenticationTokenProvider.ProviderKey)]
        string postAuthenticationToken,
        [FromBody] AdminAuthLoginWithTwoFactorRequest request) =>
        await this.authenticationActionsStrategy.LoginWithTwoFactorAuthenticatorAsync(this, postAuthenticationToken, request);

    /// <summary>
    /// Checks whether an user is authorized or not to access the administration.
    /// </summary>
    /// <returns></returns>
    [HttpPost("check")]
    public virtual async Task<IActionResult> CheckIdentity() => this.Ok();

    /// <summary>
    /// Action that returns the two factor authentication description of current user.
    /// </summary>
    /// <returns></returns>
    [HttpGet("manage/request-2fa-description")]
    public virtual async Task<IActionResult> RequestTwoFactorDescription() =>
        await this.manageActionsStrategy.RequestTwoFactorDescriptionAsync(this);

    /// <summary>
    /// Action for reset the two factor authenticator.
    /// </summary>
    /// <returns></returns>
    [HttpPost("manage/reset-2fa-authenticator")]
    public async Task<IActionResult> ResetTwoFactorAuthenticator() =>
        await this.manageActionsStrategy.ResetTwoFactorAuthenticatorAsync(this);

    /// <summary>
    /// Activates the two factor authentication.
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    [HttpPost("manage/activate-2fa")]
    public async Task<IActionResult> ActivateTwoFactorAuthentication(ActivateTwoFactorAuthenticationCommand request) =>
        await this.manageActionsStrategy.ActivateTwoFactorAuthentication(this, request);

    /// <summary>
    /// Changes the email of the current user.
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    [HttpPost("manage/change-email")]
    public async Task<IActionResult> ChangeEmail(AdminChangeEmailRequest request) =>
        await this.manageActionsStrategy.ChangeEmailAsync(this, request);

    /// <summary>
    /// Changes the password of the current user.
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    [HttpPost("manage/change-password")]
    public async Task<IActionResult> ChangePassword(AdminChangePasswordRequest request) =>
        await this.manageActionsStrategy.ChangePasswordAsync(this, request);
}