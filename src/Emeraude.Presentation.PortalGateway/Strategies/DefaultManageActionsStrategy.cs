using System;
using System.Threading.Tasks;
using Emeraude.Application.Exceptions;
using Emeraude.Application.Identity.Requests.Commands.ActivateTwoFactorAuthentication;
using Emeraude.Application.Identity.Requests.Commands.ChangeEmail;
using Emeraude.Application.Identity.Requests.Commands.ChangePassword;
using Emeraude.Application.Identity.Requests.Commands.ResetTwoFactorAuthentication;
using Emeraude.Essentials.Extensions;
using Emeraude.Essentials.Models;
using Emeraude.Infrastructure.Identity.Services;
using Emeraude.Presentation.Extensions;
using Emeraude.Presentation.PortalGateway.Controllers;
using Emeraude.Presentation.PortalGateway.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Emeraude.Presentation.PortalGateway.Strategies;

/// <inheritdoc />
public class DefaultManageActionsStrategy : IManageActionsStrategy
{
    private readonly IMediator mediator;
    private readonly ICurrentUserProvider currentUserProvider;
    private readonly ITwoFactorAuthenticationService twoFactorAuthenticationService;

    /// <summary>
    /// Initializes a new instance of the <see cref="DefaultManageActionsStrategy"/> class.
    /// </summary>
    /// <param name="mediator"></param>
    /// <param name="currentUserProvider"></param>
    /// <param name="twoFactorAuthenticationService"></param>
    public DefaultManageActionsStrategy(
        IMediator mediator,
        ICurrentUserProvider currentUserProvider,
        ITwoFactorAuthenticationService twoFactorAuthenticationService)
    {
        this.mediator = mediator;
        this.currentUserProvider = currentUserProvider;
        this.twoFactorAuthenticationService = twoFactorAuthenticationService;
    }

    /// <inheritdoc/>
    public virtual async Task<IActionResult> RequestTwoFactorDescriptionAsync(
        EmPortalGatewayApiController controller)
    {
        var currentUser = await this.currentUserProvider.GetCurrentUserAsync();

        var formattedKey = await this.twoFactorAuthenticationService.GetFormattedKeyAsync(currentUser);
        var model = new AdminTwoFactorDescriptionModel
        {
            HasAuthenticator = formattedKey != null,
            SharedKey = formattedKey,
            AuthenticatorUri = await this.twoFactorAuthenticationService.GenerateQrCodeUriAsync(currentUser),
            Is2FaEnabled = this.twoFactorAuthenticationService.IsTwoFactorEnabled(currentUser),
        };

        if (model.Is2FaEnabled)
        {
            model.SharedKey = null;
            model.AuthenticatorUri = null;
        }

        return controller.Ok(model);
    }

    /// <inheritdoc/>
    public virtual async Task<IActionResult> ResetTwoFactorAuthenticatorAsync(
        EmPortalGatewayApiController controller)
    {
        var result = await this.mediator.Send(new ResetTwoFactorAuthenticationCommand());
        return controller.Ok(result);
    }

    /// <inheritdoc/>
    public virtual async Task<IActionResult> ActivateTwoFactorAuthentication(
        EmPortalGatewayApiController controller,
        ActivateTwoFactorAuthenticationCommand request)
    {
        try
        {
            var requestResult = await this.mediator.Send(request);
            return controller.Ok(requestResult);
        }
        catch (ValidationException ex)
        {
            controller.ModelState.ApplyValidationException(ex, true);
        }
        catch (Exception)
        {
            controller.ModelState.AddModelError(string.Empty, "Two factor authentication operation has failed");
        }

        return controller.BadRequestWithModelErrors();
    }

    /// <inheritdoc/>
    public async Task<IActionResult> ChangeEmailAsync(EmPortalGatewayApiController controller, AdminChangeEmailRequest request)
    {
        try
        {
            var command = new ChangeEmailCommand
            {
                NewEmail = request.NewEmail,
                IgnoreToken = true,
            };

            var requestResult = await this.mediator.Send(command);

            if (requestResult.Succeeded)
            {
                return controller.Ok(SimpleResult.SuccessfulResult);
            }

            controller.ModelState.AddModelError(string.Empty, "Email has not been changed");
        }
        catch (ValidationException ex)
        {
            controller.ModelState.ApplyValidationException(ex, true);
        }
        catch (Exception)
        {
            controller.ModelState.AddModelError(string.Empty, "Change email request operation has failed");
        }

        return controller.BadRequestWithModelErrors();
    }

    /// <inheritdoc/>
    public async Task<IActionResult> ChangePasswordAsync(EmPortalGatewayApiController controller, AdminChangePasswordRequest request)
    {
        try
        {
            var requestResult = await this.mediator.Send(new ChangePasswordCommand
            {
                UserId = this.currentUserProvider.CurrentUserId,
                CurrentPassword = request.CurrentPassword,
                NewPassword = request.NewPassword,
                ConfirmedPassword = request.ConfirmedPassword,
            });

            if (requestResult.Succeeded)
            {
                return controller.Ok(SimpleResult.SuccessfulResult);
            }

            controller.ModelState.AddModelError(string.Empty, "Password has not been changed successfully");
        }
        catch (ValidationException ex)
        {
            controller.ModelState.ApplyValidationException(ex, true);
        }
        catch (Exception)
        {
            controller.ModelState.AddModelError(string.Empty, "Change password operation has failed");
        }

        return controller.BadRequestWithModelErrors();
    }
}