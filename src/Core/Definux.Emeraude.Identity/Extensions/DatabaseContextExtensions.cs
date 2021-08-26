using System;
using Definux.Emeraude.Application.Persistence;
using Definux.Emeraude.Identity.Common;
using Definux.Emeraude.Identity.Entities;

namespace Definux.Emeraude.Identity.Extensions
{
    /// <summary>
    /// Extensions for <see cref="IEmContext"/>.
    /// </summary>
    public static class DatabaseContextExtensions
    {
        /// <summary>
        /// Build refresh token for a user.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="user"></param>
        /// <returns></returns>
        public static (string, DateTimeOffset?) BuildRefreshToken(this IEmContext context, User user, int tokenExpirationSeconds)
        {
            string refreshToken = StaticFunctions.GenerateRefreshToken();
            user.RefreshToken = refreshToken;
            user.RefreshTokenExpiration = DateTime.UtcNow.AddSeconds(tokenExpirationSeconds);
            context.Set<User>().Update(user);

            return (user.RefreshToken, user.RefreshTokenExpiration);
        }

        /// <summary>
        /// Reset refresh token for a user.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="user"></param>
        public static void ResetRefreshToken(this IEmContext context, User user)
        {
            user.RefreshToken = null;
            user.RefreshTokenExpiration = null;
            context.Set<User>().Update(user);
        }
    }
}
