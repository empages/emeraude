using System.Threading;
using System.Threading.Tasks;
using Emeraude.Infrastructure.Identity.Services;
using MediatR;

namespace Emeraude.Application.Identity.Requests.Commands.ResetTwoFactorAuthentication
{
    /// <summary>
    /// Command for reset two factor authenticator.
    /// </summary>
    public class ResetTwoFactorAuthenticationCommand : IRequest<ResetTwoFactorAuthenticationResult>
    {
        /// <inheritdoc/>
        public class ResetTwoFactorAuthenticationCommandHandler : IRequestHandler<ResetTwoFactorAuthenticationCommand, ResetTwoFactorAuthenticationResult>
        {
            private readonly IUserManager userManager;
            private readonly ICurrentUserProvider currentUserProvider;

            /// <summary>
            /// Initializes a new instance of the <see cref="ResetTwoFactorAuthenticationCommandHandler"/> class.
            /// </summary>
            /// <param name="userManager"></param>
            /// <param name="currentUserProvider"></param>
            public ResetTwoFactorAuthenticationCommandHandler(IUserManager userManager, ICurrentUserProvider currentUserProvider)
            {
                this.userManager = userManager;
                this.currentUserProvider = currentUserProvider;
            }

            /// <inheritdoc/>
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
