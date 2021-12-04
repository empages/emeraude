using Emeraude.Essentials.Models;

namespace Emeraude.Application.Identity.Requests.Commands.ForgotPassword;

/// <summary>
/// Forgot password command result.
/// </summary>
public class ForgotPasswordRequestResult : SimpleResult
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ForgotPasswordRequestResult"/> class.
    /// </summary>
    /// <param name="success"></param>
    public ForgotPasswordRequestResult(bool success)
        : base(success)
    {
    }
}