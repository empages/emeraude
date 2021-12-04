using System.Threading;
using System.Threading.Tasks;
using Emeraude.Essentials.Base;
using Emeraude.Infrastructure.Identity.Common;
using Emeraude.Infrastructure.Identity.EventHandlers;
using Emeraude.Infrastructure.Identity.Services;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace Emeraude.Application.Identity.Requests.Commands.Login;

/// <summary>
/// Command for user login.
/// </summary>
public class LoginCommand : IRequest<LoginRequestResult>
{
    /// <summary>
    /// Email of the user.
    /// </summary>
    public string Email { get; set; }

    /// <summary>
    /// Password of the user.
    /// </summary>
    public string Password { get; set; }

    /// <inheritdoc/>
    public class LoginCommandHandler : IRequestHandler<LoginCommand, LoginRequestResult>
    {
        private readonly IUserManager userManager;
        private readonly IIdentityEventManager eventManager;

        /// <summary>
        /// Initializes a new instance of the <see cref="LoginCommandHandler"/> class.
        /// </summary>
        /// <param name="userManager"></param>
        /// <param name="eventManager"></param>
        public LoginCommandHandler(IUserManager userManager, IIdentityEventManager eventManager)
        {
            this.userManager = userManager;
            this.eventManager = eventManager;
        }

        /// <inheritdoc/>
        public async Task<LoginRequestResult> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            var user = await this.userManager.FindUserByEmailAsync(request.Email);
            var result = new LoginRequestResult
            {
                User = user,
                Result = SignInResult.Failed,
            };

            if (!await this.userManager.IsInRoleAsync(user, EmRoles.Admin) && !await this.userManager.IsInRoleAsync(user, EmRoles.User))
            {
                result.Result = SignInResult.NotAllowed;
            }
            else if (await this.userManager.IsLockedOutAsync(user))
            {
                result.Result = SignInResult.LockedOut;
            }

            if (result.Result == SignInResult.Failed && await this.userManager.CheckPasswordAsync(user, request.Password))
            {
                if (await this.userManager.GetTwoFactorEnabledAsync(user) && await this.userManager.IsInRoleAsync(user, EmRoles.Admin))
                {
                    result.Result = SignInResult.TwoFactorRequired;
                }
                else
                {
                    result.Result = SignInResult.Success;
                }
            }
            else
            {
                await this.userManager.AccessFailedAsync(user);
            }

            if (result.Result == SignInResult.Success)
            {
                await this.eventManager.TriggerLoginEventAsync(user.Id);
            }

            return result;
        }
    }
}