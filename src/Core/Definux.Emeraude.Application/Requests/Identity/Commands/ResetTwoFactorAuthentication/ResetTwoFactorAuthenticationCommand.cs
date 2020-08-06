using Definux.Emeraude.Application.Common.Interfaces.Identity.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Definux.Emeraude.Application.Requests.Identity.Commands.ResetTwoFactorAuthentication
{
    public class ResetTwoFactorAuthenticationCommand : IRequest<ResetTwoFactorAuthenticationResult>
    {
        public class ResetTwoFactorAuthenticationCommandHandler : IRequestHandler<ResetTwoFactorAuthenticationCommand, ResetTwoFactorAuthenticationResult>
        {
            private readonly IUserManager userManager;
            private readonly ICurrentUserProvider currentUserProvider;

            public ResetTwoFactorAuthenticationCommandHandler(IUserManager userManager, ICurrentUserProvider currentUserProvider)
            {
                this.userManager = userManager;
                this.currentUserProvider = currentUserProvider;
            }

            public async Task<ResetTwoFactorAuthenticationResult> Handle(ResetTwoFactorAuthenticationCommand request, CancellationToken cancellationToken)
            {
                var user = await this.currentUserProvider.GetCurrentUserAsync();

                await this.userManager.SetTwoFactorEnabledAsync(user, false);
                await this.userManager.ResetAuthenticatorKeyAsync(user);

                return new ResetTwoFactorAuthenticationResult(true);
            }
        }
    }

}
