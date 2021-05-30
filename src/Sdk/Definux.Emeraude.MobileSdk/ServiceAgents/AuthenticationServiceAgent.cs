using System.Threading.Tasks;
using Definux.Emeraude.MobileSdk.Configuration;
using Definux.Emeraude.MobileSdk.ServiceAgents.Http;
using Definux.Emeraude.MobileSdk.ServiceAgents.Models.Requests;
using Definux.Emeraude.MobileSdk.ServiceAgents.Models.Results;

namespace Definux.Emeraude.MobileSdk.ServiceAgents
{
    /// <inheritdoc cref="IAuthenticationServiceAgent"/>
    public class AuthenticationServiceAgent : ServiceAgent, IAuthenticationServiceAgent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationServiceAgent"/> class.
        /// </summary>
        /// <param name="configuration"></param>
        /// <param name="clientFactory"></param>
        public AuthenticationServiceAgent(
            IEmConfiguration configuration,
            IHttpClientFactory clientFactory)
            : base(configuration, clientFactory)
        {
        }

        /// <inheritdoc/>
        public async Task<BearerAuthenticationResult> RequestTokenAsync(LoginRequest loginRequest)
        {
            return await this.PostAsync<LoginRequest, BearerAuthenticationResult>("/api/auth/login", loginRequest);
        }

        /// <inheritdoc/>
        public async Task<BearerAuthenticationResult> RequestTokenWithExternalProviderAsync(ExternalLoginRequest externalLoginRequest)
        {
            return await this.PostAsync<ExternalLoginRequest, BearerAuthenticationResult>("/api/auth/external", externalLoginRequest);
        }
    }
}