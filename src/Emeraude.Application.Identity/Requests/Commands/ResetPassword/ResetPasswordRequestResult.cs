using Emeraude.Essentials.Models;

namespace Emeraude.Application.Identity.Requests.Commands.ResetPassword;

/// <summary>
/// Reset password command result.
/// </summary>
public class ResetPasswordRequestResult : SimpleResult
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ResetPasswordRequestResult"/> class.
    /// </summary>
    /// <param name="success"></param>
    public ResetPasswordRequestResult(bool success)
        : base(success)
    {
    }
}