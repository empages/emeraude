using System.Threading.Tasks;
using Emeraude.Application.Identity.Requests.Commands.ActivateTwoFactorAuthentication;
using Emeraude.Presentation.PortalGateway.Controllers;
using Emeraude.Presentation.PortalGateway.Models;
using Microsoft.AspNetCore.Mvc;

namespace Emeraude.Presentation.PortalGateway.Strategies;

/// <summary>
/// Manage actions strategy.
/// </summary>
public interface IManageActionsStrategy : IIdentityActionStrategy
{
    /// <summary>
    /// Request two factor description handler.
    /// </summary>
    /// <param name="controller"></param>
    /// <returns></returns>
    Task<IActionResult> RequestTwoFactorDescriptionAsync(EmPortalGatewayApiController controller);

    /// <summary>
    /// Reset two factor authenticator handler.
    /// </summary>
    /// <param name="controller"></param>
    /// <returns></returns>
    Task<IActionResult> ResetTwoFactorAuthenticatorAsync(EmPortalGatewayApiController controller);

    /// <summary>
    /// Activate two factor authentication handler.
    /// </summary>
    /// <param name="controller"></param>
    /// <param name="request"></param>
    /// <returns></returns>
    Task<IActionResult> ActivateTwoFactorAuthentication(
        EmPortalGatewayApiController controller,
        ActivateTwoFactorAuthenticationCommand request);

    /// <summary>
    /// Change email handler.
    /// </summary>
    /// <param name="controller"></param>
    /// <param name="request"></param>
    /// <returns></returns>
    Task<IActionResult> ChangeEmailAsync(
        EmPortalGatewayApiController controller,
        AdminChangeEmailRequest request);

    /// <summary>
    /// Change password handler.
    /// </summary>
    /// <param name="controller"></param>
    /// <param name="request"></param>
    /// <returns></returns>
    Task<IActionResult> ChangePasswordAsync(
        EmPortalGatewayApiController controller,
        AdminChangePasswordRequest request);
}