using Definux.Emeraude.Interfaces.Requests;

namespace Definux.Emeraude.Application.Requests.Identity.Commands.Register
{
    /// <inheritdoc cref="IRegisterRequest"/>
    public class RegisterRequest : IRegisterRequest
    {
        /// <inheritdoc/>
        public string Name { get; set; }

        /// <inheritdoc/>
        public string Email { get; set; }

        /// <inheritdoc/>
        public string Password { get; set; }

        /// <inheritdoc/>
        public string ConfirmedPassword { get; set; }
    }
}
