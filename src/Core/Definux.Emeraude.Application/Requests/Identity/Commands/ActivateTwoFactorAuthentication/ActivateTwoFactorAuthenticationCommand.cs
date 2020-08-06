using Definux.Emeraude.Application.Common.Interfaces.Identity.Services;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Definux.Emeraude.Application.Requests.Identity.Commands.ActivateTwoFactorAuthentication
{
    public class ActivateTwoFactorAuthenticationCommand : IRequest<ActivateTwoFactorAuthenticationResult>
    {

        public ActivateTwoFactorAuthenticationCommand(string code)
        {
            Code = code;
        }

        public string Code { get; set; }

        public class ActivateTwoFactorAuthenticationCommandHandler : IRequestHandler<ActivateTwoFactorAuthenticationCommand, ActivateTwoFactorAuthenticationResult>
        {
            private readonly IUserManager userManager;
            private readonly ICurrentUserProvider currentUserProvider;

            public ActivateTwoFactorAuthenticationCommandHandler(IUserManager userManager, ICurrentUserProvider currentUserProvider)
            {
                this.userManager = userManager;
                this.currentUserProvider = currentUserProvider;
            }

            public async Task<ActivateTwoFactorAuthenticationResult> Handle(ActivateTwoFactorAuthenticationCommand request, CancellationToken cancellationToken)
            {
                var verificationCode = request.Code.Replace(" ", string.Empty).Replace("-", string.Empty);

                var currentUser = await this.currentUserProvider.GetCurrentUserAsync();

                var is2faTokenValid = await this.userManager
                    .VerifyTwoFactorTokenAsync(
                        currentUser, 
                        this.userManager.Options.Tokens.AuthenticatorTokenProvider, 
                        verificationCode);

                if (!is2faTokenValid)
                {
                    return new ActivateTwoFactorAuthenticationResult(false);
                }

                await this.userManager.SetTwoFactorEnabledAsync(currentUser, true);

                return new ActivateTwoFactorAuthenticationResult(true);
            }
        }
    }

}
