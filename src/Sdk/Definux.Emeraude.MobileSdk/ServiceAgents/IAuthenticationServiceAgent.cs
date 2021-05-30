using System.Threading.Tasks;
using Definux.Emeraude.MobileSdk.ServiceAgents.Models.Requests;
using Definux.Emeraude.MobileSdk.ServiceAgents.Models.Results;

namespace Definux.Emeraude.MobileSdk.ServiceAgents
{
    /// <summary>
    /// Service agent that provides access to the authentication API.
    /// </summary>
    public interface IAuthenticationServiceAgent
    {
        /// <summary>
        /// Request access token via ordinary login request with email and password.
        /// </summary>
        /// <param name="loginRequest"></param>
        /// <returns></returns>
        Task<BearerAuthenticationResult> RequestTokenAsync(LoginRequest loginRequest);

        /// <summary>
        /// Request access token via external provider token.
        /// </summary>
        /// <param name="externalLoginRequest"></param>
        /// <returns></returns>
        Task<BearerAuthenticationResult> RequestTokenWithExternalProviderAsync(ExternalLoginRequest externalLoginRequest);
    }
}
