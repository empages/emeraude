using Definux.Emeraude.MobileSdk.Configuration;
using Definux.Emeraude.MobileSdk.ServiceAgents.Http;
using Definux.Emeraude.MobileSdk.ServiceAgents.Models.Requests;
using Definux.Emeraude.MobileSdk.ServiceAgents.Models.Results;
using System.Threading.Tasks;

namespace Definux.Emeraude.MobileSdk.ServiceAgents
{
    public class AuthenticationServiceAgent : ServiceAgent, IAuthenticationServiceAgent
    {
        public AuthenticationServiceAgent(
            IEmConfiguration configuration,
            IHttpClientFactory clientFactory)
            : base(configuration, clientFactory)
        {

        }

        public async Task<BearerAuthenticationResult> RequestTokenAsync(LoginRequest loginRequest)
        {
            return await this.PostAsync<LoginRequest, BearerAuthenticationResult>("/api/auth/login", loginRequest);
        }

        public async Task<BearerAuthenticationResult> RequestTokenWithExternalProviderAsync(ExternalLoginRequest externalLoginRequest)
        {
            return await this.PostAsync<ExternalLoginRequest, BearerAuthenticationResult>("/api/auth/external", externalLoginRequest);
        }
    }
}
