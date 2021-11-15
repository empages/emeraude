using System.Security.Claims;
using System.Threading.Tasks;
using Emeraude.Infrastructure.Identity.Services;
using Microsoft.AspNetCore.Authentication;

namespace Emeraude.Infrastructure.Identity.ExternalProviders
{
    /// <summary>
    /// Provides external provider authenticator for registration and consuming external authentication services.
    /// </summary>
    public interface IExternalProviderAuthenticator
    {
        /// <summary>
        /// Client id.
        /// </summary>
        string ClientId { get; set; }

        /// <summary>
        /// Client secret.
        /// </summary>
        string ClientSecret { get; set; }

        /// <summary>
        /// Gets the external provider name.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets external user stored in the claims principal of the request.
        /// </summary>
        /// <param name="principal"></param>
        /// <returns></returns>
        Task<IExternalUser> GetExternalUserAsync(ClaimsPrincipal principal);

        /// <summary>
        /// Gets external user based on the provider name and its provided access token.
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="accessToken"></param>
        /// <returns></returns>
        Task<IExternalUser> GetExternalUserAsync(string provider, string accessToken);

        /// <summary>
        /// Register authenticator into the authentication settings.
        /// </summary>
        /// <param name="builder"></param>
        void RegisterAuthenticator(AuthenticationBuilder builder);
    }
}