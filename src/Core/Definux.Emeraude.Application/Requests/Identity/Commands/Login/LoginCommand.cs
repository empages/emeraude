using Definux.Emeraude.Application.Common.Interfaces.Identity.EventHandlers;
using Definux.Emeraude.Application.Common.Interfaces.Identity.Services;
using Definux.Emeraude.Configuration.Authorization;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System.Threading;
using System.Threading.Tasks;

namespace Definux.Emeraude.Application.Requests.Identity.Commands.Login
{
    public class LoginCommand : LoginRequest, IRequest<LoginRequestResult>
    {
        public LoginCommand(LoginRequest loginRequest)
        {
            Email = loginRequest.Email;
            Password = loginRequest.Password;
        }

        public class LoginCommandHandler : IRequestHandler<LoginCommand, LoginRequestResult>
        {
            private readonly IUserManager userManager;
            private readonly IIdentityEventManager eventManager;

            public LoginCommandHandler(IUserManager userManager, IIdentityEventManager eventManager)
            {
                this.userManager = userManager;
                this.eventManager = eventManager;
            }

            public async Task<LoginRequestResult> Handle(LoginCommand request, CancellationToken cancellationToken)
            {
                var user = await this.userManager.FindUserByEmailAsync(request.Email);
                var result = new LoginRequestResult
                {
                    User = user,
                    Result = SignInResult.Success
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
