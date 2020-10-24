using Definux.Emeraude.Interfaces.Requests;

namespace Definux.Emeraude.Application.Requests.Identity.Commands.Login
{
    /// <inheritdoc cref="ILoginRequest"/>
    public class LoginRequest : ILoginRequest
    {
        /// <inheritdoc/>
        public string Email { get; set; }

        /// <inheritdoc/>
        public string Password { get; set; }
    }
}
