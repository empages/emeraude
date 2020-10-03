using System.Threading;
using System.Threading.Tasks;
using Definux.Emeraude.Application.Common.Interfaces.Identity.EventHandlers;
using Definux.Emeraude.Application.Common.Interfaces.Identity.Services;
using Definux.Emeraude.Configuration.Authorization;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace Definux.Emeraude.Application.Requests.Identity.Commands.Login
{
    /// <summary>
    /// Command for user login.
    /// </summary>
    public class LoginCommand : LoginRequest, IRequest<LoginRequestResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoginCommand"/> class.
        /// </summary>
        /// <param name="loginRequest"></param>
        public LoginCommand(LoginRequest loginRequest)
        {
            this.Email = loginRequest.Email;
            this.Password = loginRequest.Password;
        }

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
                    Result = SignInResult.Success,
                };

                if (!await this.userManager.IsInRoleAsync(user, ApplicationRoles.Admin) && !await this.userManager.IsInRoleAsync(user, ApplicationRoles.User))
                {
                    result.Result = SignInResult.NotAllowed;
                }
                else if (await this.userManager.IsLockedOutAsync(user))
                {
                    result.Result = SignInResult.LockedOut;
                }
                else if (await this.userManager.GetTwoFactorEnabledAsync(user) && await this.userManager.IsInRoleAsync(user, ApplicationRoles.Admin))
                {
                    result.Result = SignInResult.TwoFactorRequired;
                }
                else if (result.Result == SignInResult.Success)
                {
                    await this.eventManager.TriggerLoginEventAsync(user.Id);
                }

                return result;
            }
        }
    }
}
