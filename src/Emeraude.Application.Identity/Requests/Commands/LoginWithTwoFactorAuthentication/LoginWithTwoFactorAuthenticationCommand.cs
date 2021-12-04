using System.Threading;
using System.Threading.Tasks;
using Emeraude.Contracts;
using Emeraude.Infrastructure.Identity.Services;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace Emeraude.Application.Identity.Requests.Commands.LoginWithTwoFactorAuthentication;

/// <summary>
/// Command for user login with two factor authentication.
/// </summary>
public class LoginWithTwoFactorAuthenticationCommand : IRequest<LoginWithTwoFactorAuthenticationRequestResult>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="LoginWithTwoFactorAuthenticationCommand"/> class.
    /// </summary>
    /// <param name="user"></param>
    /// <param name="code"></param>
    public LoginWithTwoFactorAuthenticationCommand(IUser user, string code)
    {
        this.User = user;
        this.Code = code;
    }

    /// <summary>
    /// Two factor authentication code.
    /// </summary>
    public string Code { get; set; }

    /// <summary>
    /// Target user.
    /// </summary>
    public IUser User { get; set; }

    /// <inheritdoc/>
    public class LoginWithTwoFactorAuthenticationCommandHandler : IRequestHandler<LoginWithTwoFactorAuthenticationCommand, LoginWithTwoFactorAuthenticationRequestResult>
    {
        private const string TwoFactorAuthenticationTokenProvider = "Authenticator";

        private readonly IUserManager userManager;

        /// <summary>
        /// Initializes a new instance of the <see cref="LoginWithTwoFactorAuthenticationCommandHandler"/> class.
        /// </summary>
        /// <param name="userManager"></param>
        public LoginWithTwoFactorAuthenticationCommandHandler(IUserManager userManager)
        {
            this.userManager = userManager;
        }

        /// <inheritdoc/>
        public async Task<LoginWithTwoFactorAuthenticationRequestResult> Handle(LoginWithTwoFactorAuthenticationCommand request, CancellationToken cancellationToken)
        {
            var result = new LoginWithTwoFactorAuthenticationRequestResult
            {
                User = request.User,
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