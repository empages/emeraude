using System;
using Definux.Utilities.Objects;
using Microsoft.IdentityModel.Tokens;

namespace Definux.Emeraude.Infrastructure.Identity.Models
{
    /// <summary>
    /// Bearer authentication result for API authentication request.
    /// </summary>
    public class BearerAuthenticationResult : SimpleResult
    {
        /// <summary>
        /// Static property that returns failed bearer result.
        /// </summary>
        public static BearerAuthenticationResult FailedResult => new ()
        {
            Succeeded = false,
            Message = "Authentication failed",
        };

        /// <summary>
        /// Message of the result.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Access token.
        /// </summary>
        public string AccessToken { get; set; }

        /// <summary>
        /// Refresh token.
        /// </summary>
        public string RefreshToken { get; set; }

        /// <summary>
        /// Refresh token expiration.
        /// </summary>
        public long RefreshTokenExpiration { get; set; }

        /// <summary>
        /// Static method that returns success bearer result.
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="refreshToken"></param>
        /// <param name="refreshTokenExpirationDate"></param>
        /// <returns></returns>
        public static BearerAuthenticationResult SuccessResult(
            string accessToken,
            string refreshToken,
            DateTimeOffset refreshTokenExpirationDate) =>
            new ()
            {
                Succeeded = true,
                Message = "Successful authentication",
                AccessToken = accessToken,
                RefreshToken = refreshToken,
                RefreshTokenExpiration = EpochTime.GetIntDate(refreshTokenExpirationDate.UtcDateTime),
            };

        /// <summary>
        /// Converts the result to simple encapsulated version.
        /// </summary>
        /// <returns></returns>
        public BearerAuthenticationSimpleResult ToSimpleResult() =>
            new (this.Succeeded)
            {
                Message = this.Message,
                AccessToken = this.AccessToken,
            };
    }
}
