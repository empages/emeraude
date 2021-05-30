using Definux.Emeraude.Interfaces.Requests;

namespace Definux.Emeraude.MobileSdk.ServiceAgents.Models.Requests
{
    /// <inheritdoc />
    public class LoginRequest : ILoginRequest
    {
        /// <summary>
        /// Request email.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Request password.
        /// </summary>
        public string Password { get; set; }
    }
}
