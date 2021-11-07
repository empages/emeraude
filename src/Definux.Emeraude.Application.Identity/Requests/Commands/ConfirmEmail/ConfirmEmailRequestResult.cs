using Definux.Utilities.Objects;

namespace Definux.Emeraude.Application.Identity.Requests.Commands.ConfirmEmail
{
    /// <summary>
    /// Confirm email command result.
    /// </summary>
    public class ConfirmEmailRequestResult : SimpleResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfirmEmailRequestResult"/> class.
        /// </summary>
        /// <param name="success"></param>
        public ConfirmEmailRequestResult(bool success)
            : base(success)
        {
        }
    }
}
