using Definux.Emeraude.Application.Common.Interfaces.Identity.Services;
using Definux.Emeraude.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Definux.Emeraude.Application.Requests.Identity.Commands.LoginWithTwoFactorAuthentication
{
    public class LoginWithTwoFactorAuthenticationCommand : IRequest<LoginWithTwoFactorAuthenticationRequestResult>
    {
        public LoginWithTwoFactorAuthenticationCommand(IUser user, string code)
        {
            User = user;
            Code = code;
        }

        public string Code { get; set; }

        public IUser User { get; set; }

        public class LoginWithTwoFactorAuthenticationCommandHandler : IRequestHandler<LoginWithTwoFactorAuthenticationCommand, LoginWithTwoFactorAuthenticationRequestResult>
        {
            private const string TwoFactorAuthenticationTokenProvider = "Authenticator";

            private readonly IUserManager userManager;
            private readonly ICurrentUserProvider currentUserProvider;

            public LoginWithTwoFactorAuthenticationCommandHandler(IUserManager userManager, ICurrentUserProvider currentUserProvider)
            {
                this.userManager = userManager;
                this.currentUserProvider = currentUserProvider;
            }

            public async Task<LoginWithTwoFactorAuthenticationRequestResult> Handle(LoginWithTwoFactorAuthenticationCommand request, CancellationToken cancellationToken)
            {
                var result = new LoginWithTwoFactorAuthenticationRequestResult
                {
                    User = request.User
                };

                var authenticatorCode = request.Code.Replace(" ", string.Empty).Replace("-", string.Empty);

                if (await this.userManager.IsLockedOutAsync(request.User))
                {
                    result.Result = SignInResult.LockedOut;
                    return result;
                }

                var isAuthenticationCodeCorrect = await this.userManager.VerifyTwoFactorTokenAsync(request.User, TwoFactorAuthenticationTokenProvider, authenticatorCode);
                if (isAuthenticationCodeCorrect)
                {
                    result.Result = SignInResult.Success;
                }
                else
                {
                    await this.userManager.AccessFailedAsync(request.User);
                    result.Result = SignInResult.Failed;
                }

                return result;
            }
        }
    }

}
