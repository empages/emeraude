using Definux.Emeraude.Interfaces.Requests;

namespace Definux.Emeraude.Application.Requests.Identity.Commands.ResetPassword
{
    /// <inheritdoc cref="IResetPasswordRequest"/>
    public class ResetPasswordRequest : IResetPasswordRequest
    {
        /// <inheritdoc/>
        public string Email { get; set; }

        /// <inheritdoc/>
        public string Password { get; set; }

        /// <inheritdoc/>
        public string ConfirmedPassword { get; set; }

        /// <inheritdoc/>
        public string Token { get; set; }
    }
}
