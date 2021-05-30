using Definux.Utilities.Objects;

namespace Definux.Emeraude.Application.Requests.Identity.Commands.ResetPassword
{
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
}
