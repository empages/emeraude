using Definux.Emeraude.MobileSdk.ServiceAgents.Models.Requests;
using Definux.Emeraude.MobileSdk.ServiceAgents.Models.Results;
using System.Threading.Tasks;

namespace Definux.Emeraude.MobileSdk.ServiceAgents
{
    public interface IAuthenticationServiceAgent
    {
        Task<BearerAuthenticationResult> RequestTokenAsync(LoginRequest loginRequest);

        Task<BearerAuthenticationResult> RequestTokenWithExternalProviderAsync(ExternalLoginRequest externalLoginRequest);
    }
}
