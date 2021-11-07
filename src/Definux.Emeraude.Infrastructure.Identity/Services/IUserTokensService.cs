using System;
using System.Threading.Tasks;
using Definux.Emeraude.Contracts;
using Definux.Emeraude.Infrastructure.Identity.Models;

namespace Definux.Emeraude.Infrastructure.Identity.Services
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
        Task<BearerAuthenticationResult> BuildJwtTokenForUserAsync(Guid userId, TimeSpan? expiration = null);

        /// <summary>
        /// Build JSON web token for specified user.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="expiration"></param>
        /// <returns></returns>
        Task<BearerAuthenticationResult> BuildJwtTokenForUserAsync(IUser user, TimeSpan? expiration = null);

        /// <summary>
        /// Build JSON web token for specified user.
        /// </summary>
        /// <param name="userEmail"></param>
        /// <param name="expiration"></param>
        /// <returns></returns>
        Task<BearerAuthenticationResult> BuildJwtTokenForUserAsync(string userEmail, TimeSpan? expiration = null);

        /// <summary>
        /// Build JSON web token for specified external user.
        /// </summary>
        /// <param name="externalUser"></param>
        /// <param name="expiration"></param>
        /// <returns></returns>
        Task<BearerAuthenticationResult> BuildJwtTokenForExternalUserAsync(IExternalUser externalUser, TimeSpan? expiration = null);

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
