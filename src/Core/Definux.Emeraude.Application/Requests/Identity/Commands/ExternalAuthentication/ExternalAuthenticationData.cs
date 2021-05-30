using Definux.Emeraude.Interfaces.Requests;

namespace Definux.Emeraude.Application.Requests.Identity.Commands.ExternalAuthentication
{
    /// <inheritdoc cref="IExternalLoginRequest"/>
    public class ExternalAuthenticationData : IExternalLoginRequest
    {
        /// <inheritdoc/>
        public string Provider { get; set; }

        /// <inheritdoc/>
        public string AccessToken { get; set; }
    }
}
