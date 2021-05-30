using System;
using System.Threading.Tasks;
using Definux.Emeraude.Application.Requests.Identity.Commands.ExternalAuthentication;

namespace Definux.Emeraude.Application.Identity
{
    /// <summary>
    /// Service that provides methods for generation of access and refresh tokens.
    /// </summary>
    public interface IUserTokensService
    {
        /// <summary>
        /// Build JSON web token for specified user.
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        Task<BearerAuthenticationResult> BuildJwtTokenForUserAsync(Guid userId);

        /// <summary>
        /// Build JSON web token for specified external user.
        /// </summary>
        /// <param name="externalUser"></param>
        /// <returns></returns>
        Task<BearerAuthenticationResult> BuildJwtTokenForExternalUserAsync(IExternalUser externalUser);

        /// <summary>
        /// Refresh JSON web token for specified user by refresh token.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="refreshToken"></param>
        /// <returns></returns>
        Task<BearerAuthenticationResult> RefreshJwtTokenAsync(Guid? userId, string refreshToken);

        /// <summary>
        /// Reset refresh token for specified user.
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        Task<bool> ResetRefreshTokenAsync(Guid userId);
    }
}
