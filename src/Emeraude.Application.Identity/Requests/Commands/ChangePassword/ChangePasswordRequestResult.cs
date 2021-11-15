using Definux.Utilities.Objects;

namespace Emeraude.Application.Identity.Requests.Commands.ChangePassword
{
    /// <summary>
    /// Change password command result.
    /// </summary>
    public class ChangePasswordRequestResult : SimpleResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangePasswordRequestResult"/> class.
        /// </summary>
        /// <param name="success"></param>
        public ChangePasswordRequestResult(bool success = false)
            : base(success)
        {
        }
    }
}
