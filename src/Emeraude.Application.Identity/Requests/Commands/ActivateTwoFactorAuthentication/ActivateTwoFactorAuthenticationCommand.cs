using System.Threading;
using System.Threading.Tasks;
using Emeraude.Infrastructure.Identity.Services;
using MediatR;

namespace Emeraude.Application.Identity.Requests.Commands.ActivateTwoFactorAuthentication;

/// <summary>
/// Command for activation two factor authentication for a user.
/// </summary>
public class ActivateTwoFactorAuthenticationCommand : IRequest<ActivateTwoFactorAuthenticationResult>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ActivateTwoFactorAuthenticationCommand"/> class.
    /// </summary>
    /// <param name="code"></param>
    public ActivateTwoFactorAuthenticationCommand(string code)
    {
        this.Code = code;
    }

    /// <summary>
    /// Authenticator code.
    /// </summary>
    public string Code { get; set; }

    /// <summary>
    /// Activate two factor authentication command handler.
    /// </summary>
    public class ActivateTwoFactorAuthenticationCommandHandler : IRequestHandler<ActivateTwoFactorAuthenticationCommand, ActivateTwoFactorAuthenticationResult>
    {
        private readonly IUserManager userManager;
        private readonly ICurrentUserProvider currentUserProvider;

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivateTwoFactorAuthenticationCommandHandler"/> class.
        /// </summary>
        /// <param name="userManager"></param>
        /// <param name="currentUserProvider"></param>
        public ActivateTwoFactorAuthenticationCommandHandler(IUserManager userManager, ICurrentUserProvider currentUserProvider)
        {
            this.userManager = userManager;
            this.currentUserProvider = currentUserProvider;
        }

        /// <inheritdoc/>
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