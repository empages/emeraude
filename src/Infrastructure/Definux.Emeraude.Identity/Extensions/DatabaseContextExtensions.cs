using Definux.Emeraude.Application.Common.Interfaces.Persistence;
using Definux.Emeraude.Identity.Common;
using Definux.Emeraude.Identity.Entities;
using System;

namespace Definux.Emeraude.Identity.Extensions
{
    public static class DatabaseContextExtensions
    {
        public static string BuildRefreshToken(this IEmContext context, User user)
        {
            string refreshToken = StaticFunctions.GenerateRefreshToken();
            user.RefreshToken = refreshToken;
            user.RefreshTokenExpiration = DateTime.Now.AddYears(1);
            context.Set<User>().Update(user);

            return refreshToken;
        }

        public static void ResetRefreshToken(this IEmContext context, User user)
        {
            user.RefreshToken = null;
            user.RefreshTokenExpiration = null;
            context.Set<User>().Update(user);
        }
    }
}
