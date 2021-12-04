using Emeraude.Contracts;
using Microsoft.AspNetCore.Identity;

namespace Emeraude.Application.Identity.Requests.Commands.LoginWithTwoFactorAuthentication;

/// <summary>
/// Login with two factor authenticaiton command result.
/// </summary>
public class LoginWithTwoFactorAuthenticationRequestResult
{
    /// <inheritdoc cref="SignInResult"/>
    public SignInResult Result { get; set; }

    /// <summary>
    /// Target user.
    /// </summary>
    public IUser User { get; set; }
}