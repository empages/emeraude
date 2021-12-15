using System.Threading.Tasks;
using Emeraude.Presentation.PortalGateway.Controllers;
using Emeraude.Presentation.PortalGateway.Models;
using Microsoft.AspNetCore.Mvc;

namespace Emeraude.Presentation.PortalGateway.Strategies;

/// <summary>
/// Authentication actions strategy.
/// </summary>
public interface IAuthenticationActionsStrategy : IIdentityActionStrategy
{
    /// <summary>
    /// Login handler.
    /// </summary>
    /// <param name="controller"></param>
    /// <param name="request"></param>
    /// <returns></returns>
    Task<IActionResult> LoginAsync(
        EmPortalGatewayApiController controller,
        AdminAuthLoginRequest request);

    /// <summary>
    /// Login with two factor authenticator handler.
    /// </summary>
    /// <param name="controller"></param>
    /// <param name="postAuthenticationToken"></param>
    /// <param name="request"></param>
    /// <returns></returns>
    Task<IActionResult> LoginWithTwoFactorAuthenticatorAsync(
        EmPortalGatewayApiController controller,
        string postAuthenticationToken,
        AdminAuthLoginWithTwoFactorRequest request);
}