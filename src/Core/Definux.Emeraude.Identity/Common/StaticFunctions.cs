using System;
using System.Security.Cryptography;

namespace Definux.Emeraude.Identity.Common
{
    public static class StaticFunctions
    {
        public static string GenerateRefreshToken()
        {
            var randomNumber = new byte[32];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(randomNumber);
                return Convert.ToBase64String(randomNumber);
            }
        }
    }
}
