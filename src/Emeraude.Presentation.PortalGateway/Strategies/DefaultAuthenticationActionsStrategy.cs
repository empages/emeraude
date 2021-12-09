using System;
using System.Threading.Tasks;
using Emeraude.Application.Exceptions;
using Emeraude.Application.Identity.Requests.Commands.Login;
using Emeraude.Application.Identity.Requests.Commands.LoginWithTwoFactorAuthentication;
using Emeraude.Infrastructure.Identity.Services;
using Emeraude.Infrastructure.Identity.TokenProviders;
using Emeraude.Presentation.Extensions;
using Emeraude.Presentation.PortalGateway.Controllers;
using Emeraude.Presentation.PortalGateway.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Emeraude.Presentation.PortalGateway.Strategies;

/// <inheritdoc />
public class DefaultAuthenticationActionsStrategy : IAuthenticationActionsStrategy
{
    private readonly IMediator mediator;
    private readonly IUserManager userManager;
    private readonly IUserTokensService userTokensService;
    private readonly IUserClaimsService claimsService;

    /// <summary>
    /// Initializes a new instance of the <see cref="DefaultAuthenticationActionsStrategy"/> class.
    /// </summary>
    /// <param name="mediator"></param>
    /// <param name="userManager"></param>
    /// <param name="userTokensService"></param>
    /// <param name="claimsService"></param>
    public DefaultAuthenticationActionsStrategy(
        IMediator mediator,
        IUserManager userManager,
        IUserTokensService userTokensService,
        IUserClaimsService claimsService)
    {
        this.mediator = mediator;
        this.userManager = userManager;
        this.userTokensService = userTokensService;
        this.claimsService = claimsService;
    }

    /// <inheritdoc/>
    public virtual async Task<IActionResult> LoginAsync(EmPortalGatewayApiController controller, AdminAuthLoginRequest request)
    {
        if (controller.User.Identity?.IsAuthenticated ?? true)
        {
            return controller.BadRequest();
        }

        if (!await this.claimsService.CheckUserForAccessAdministrationPermissionAsync(request.Email))
        {
            controller.ModelState.AddModelError(string.Empty, Strings.TheEmailAddressOrPasswordIsIncorrect);
            return controller.BadRequestWithModelErrors();
        }

        try
        {
            var requestResult = await this.mediator.Send(new LoginCommand
            {
                Email = request.Email,
                Password = request.Password,
            });
            if (requestResult.Result.RequiresTwoFactor)
            {
                var postAuthenticationToken = await this.userManager.GenerateUserTokenAsync(
                    requestResult.User,
                    EmPostAuthenticationTokenProvider.ProviderName,
                    EmPortalConstants.PostAuthenticationPurpose);

                return controller.Ok(new AdminAuthResponse(true)
                {
                    PostAuthenticationToken = postAuthenticationToken,
                    Message = Strings.AuthenticationRequiresAdditionalFactorToBeConfirmed,
                });
            }

            if (requestResult.Result.Succeeded)
            {
                var tokenResult = await this.userTokensService.BuildJwtTokenForUserAsync(requestResult.User.Id, EmPortalConstants.AccessTokenExpiration);
                return controller.Ok(new AdminAuthResponse(tokenResult.ToSimpleResult()));
            }

            var errorMessage = requestResult.Result.IsLockedOut
                ? Strings.YourProfileIsTemporaryLockedOut
                : Strings.TheEmailAddressOrPasswordIsIncorrect;

            controller.ModelState.AddModelError(string.Empty, errorMessage);
        }
        catch (ValidationException ex)
        {
            controller.ModelState.ApplyValidationException(ex);
        }
        catch (Exception)
        {
            controller.ModelState.AddModelError(string.Empty, Strings.YourLoginAttemptHasFailed);
        }

        return controller.BadRequestWithModelErrors();
    }

    /// <inheritdoc/>
    public virtual async Task<IActionResult> LoginWithTwoFactorAuthenticatorAsync(
        EmPortalGatewayApiController controller,
        string postAuthenticationToken,
        AdminAuthLoginWithTwoFactorRequest request)
    {
        if (controller.User.Identity?.IsAuthenticated ?? true)
        {
            return controller.BadRequest();
        }

        if (!await this.claimsService.CheckUserForAccessAdministrationPermissionAsync(request.Email))
        {
            controller.ModelState.AddModelError(string.Empty, Strings.TheEmailAddressOrPasswordIsIncorrect);
            return controller.BadRequestWithModelErrors();
        }

        try
        {
            var user = await this.userManager.FindUserByEmailAsync(request.Email);
            if (user == null || !(await this.claimsService.CheckUserForAccessAdministrationPermissionAsync(user.Email)))
            {
                return controller.NotFound();
            }

            var isLoggedIn = await this.userManager.VerifyUserTokenAsync(
                user,
                EmPostAuthenticationTokenProvider.ProviderName,
                EmPortalConstants.PostAuthenticationPurpose,
                postAuthenticationToken);

            if (!isLoggedIn)
            {
                return controller.BadRequest();
            }

            var requestResult = await this.mediator.Send(new LoginWithTwoFactorAuthenticationCommand(user, request.Code));
            if (requestResult.Result.Succeeded)
            {
                var tokenResult = await this.userTokensService.BuildJwtTokenForUserAsync(requestResult.User.Id, EmPortalConstants.AccessTokenExpiration);
                return controller.Ok(tokenResult.ToSimpleResult());
            }

            var errorMessage = requestResult.Result.IsLockedOut
                ? Strings.YourProfileIsTemporaryLockedOut
                : Strings.YourLoginAttemptHasFailed;

            controller.ModelState.AddModelError(string.Empty, errorMessage);
        }
        catch (ValidationException ex)
        {
            controller.ModelState.ApplyValidationException(ex, true);
        }
        catch (Exception)
        {
            controller.ModelState.AddModelError(string.Empty, Strings.YourLoginAttemptHasFailed);
        }

        return controller.BadRequestWithModelErrors();
    }
}