using System;
using System.Threading.Tasks;
using Emeraude.Application.Exceptions;
using Emeraude.Application.Identity.Requests.Commands.Login;
using Emeraude.Application.Identity.Requests.Commands.LoginWithTwoFactorAuthentication;
using Emeraude.Essentials.Base;
using Emeraude.Infrastructure.Identity.Services;
using Emeraude.Infrastructure.Identity.TokenProviders;
using Emeraude.Presentation.Extensions;
using Emeraude.Presentation.PortalGateway.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Emeraude.Presentation.PortalGateway.Controllers.Admin
{
    /// <summary>
    /// Admin authentication API controller.
    /// </summary>
    [Route("/_em/api/admin/auth/")]
    public sealed class AdminAuthApiController : EmPortalGatewayApiController
    {
        private const string PostAuthenticationPurpose = "AccessAdministration";

#if DEBUG
        private readonly TimeSpan accessTokenExpiration = TimeSpan.FromDays(1);
#else
        private readonly TimeSpan accessTokenExpiration = TimeSpan.FromHours(1);
#endif

        private readonly IUserClaimsService claimsService;
        private readonly IUserTokensService userTokensService;
        private readonly IUserManager userManager;

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminAuthApiController"/> class.
        /// </summary>
        /// <param name="claimsService"></param>
        /// <param name="userTokensService"></param>
        /// <param name="userManager"></param>
        public AdminAuthApiController(
            IUserClaimsService claimsService,
            IUserTokensService userTokensService,
            IUserManager userManager)
        {
            this.claimsService = claimsService;
            this.userTokensService = userTokensService;
            this.userManager = userManager;
        }

        /// <summary>
        /// Login action.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody]LoginCommand request)
        {
            if (this.User.Identity?.IsAuthenticated ?? true)
            {
                return this.BadRequest();
            }

            if (!await this.claimsService.CheckUserForAccessAdministrationPermissionAsync(request.Email))
            {
                this.ModelState.AddModelError(string.Empty, Strings.TheEmailAddressOrPasswordIsIncorrect);
                return this.BadRequestWithModelErrors();
            }

            try
            {
                var requestResult = await this.Mediator.Send(request);
                if (requestResult.Result.RequiresTwoFactor)
                {
                    var postAuthenticationToken = await this.userManager.GenerateUserTokenAsync(
                        requestResult.User,
                        EmPostAuthenticationTokenProvider.ProviderName,
                        PostAuthenticationPurpose);

                    return this.Ok(new AdminAuthResponse(true)
                    {
                        PostAuthenticationToken = postAuthenticationToken,
                        Message = Strings.AuthenticationRequiresAdditionalFactorToBeConfirmed,
                    });
                }

                if (requestResult.Result.Succeeded)
                {
                    var tokenResult = await this.userTokensService.BuildJwtTokenForUserAsync(requestResult.User.Id, this.accessTokenExpiration);
                    return this.Ok(new AdminAuthResponse(tokenResult.ToSimpleResult()));
                }

                var errorMessage = requestResult.Result.IsLockedOut
                    ? Strings.YourProfileIsTemporaryLockedOut
                    : Strings.TheEmailAddressOrPasswordIsIncorrect;

                this.ModelState.AddModelError(string.Empty, errorMessage);
            }
            catch (ValidationException ex)
            {
                this.ModelState.ApplyValidationException(ex);
            }
            catch (Exception)
            {
                this.ModelState.AddModelError(string.Empty, Strings.YourLoginAttemptHasFailed);
            }

            return this.BadRequestWithModelErrors();
        }

        /// <summary>
        /// Login with second factor.
        /// </summary>
        /// <param name="postAuthenticationToken"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("login-2fa")]
        public async Task<IActionResult> LoginWithTwoFactorAuthentication(
            [FromHeader(Name = EmPostAuthenticationTokenProvider.ProviderKey)]string postAuthenticationToken,
            [FromBody]LoginWithTwoFactorAuthenticationRequest request)
        {
            if (this.User.Identity?.IsAuthenticated ?? true)
            {
                return this.BadRequest();
            }

            if (!await this.claimsService.CheckUserForAccessAdministrationPermissionAsync(request.Email))
            {
                this.ModelState.AddModelError(string.Empty, Strings.TheEmailAddressOrPasswordIsIncorrect);
                return this.BadRequestWithModelErrors();
            }

            try
            {
                var user = await this.userManager.FindUserByEmailAsync(request.Email);
                if (user == null || !(await this.claimsService.CheckUserForAccessAdministrationPermissionAsync(user.Email)))
                {
                    return this.NotFound();
                }

                var isLoggedIn = await this.userManager.VerifyUserTokenAsync(
                    user,
                    EmPostAuthenticationTokenProvider.ProviderName,
                    PostAuthenticationPurpose,
                    postAuthenticationToken);

                if (!isLoggedIn)
                {
                    return this.BadRequest();
                }

                var requestResult = await this.Mediator.Send(new LoginWithTwoFactorAuthenticationCommand(user, request.Code));
                if (requestResult.Result.Succeeded)
                {
                    var tokenResult = await this.userTokensService.BuildJwtTokenForUserAsync(requestResult.User.Id, this.accessTokenExpiration);
                    return this.Ok(tokenResult.ToSimpleResult());
                }

                var errorMessage = requestResult.Result.IsLockedOut
                    ? Strings.YourProfileIsTemporaryLockedOut
                    : Strings.YourLoginAttemptHasFailed;

                this.ModelState.AddModelError(string.Empty, errorMessage);
            }
            catch (ValidationException ex)
            {
                this.ModelState.ApplyValidationException(ex, true);
            }
            catch (Exception)
            {
                this.ModelState.AddModelError(string.Empty, Strings.YourLoginAttemptHasFailed);
            }

            return this.BadRequestWithModelErrors();
        }

        /// <summary>
        /// Checks whether an user is authorized or not to access the administration.
        /// </summary>
        /// <returns></returns>
        [HttpPost("check")]
        [Authorize(Policy = EmPermissions.AccessAdministrationPolicy)]
        public async Task<IActionResult> CheckAuthorization()
        {
            return this.Ok();
        }
    }
}