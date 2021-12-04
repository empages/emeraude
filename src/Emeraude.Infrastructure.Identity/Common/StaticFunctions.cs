using System;
using System.Security.Cryptography;

namespace Emeraude.Infrastructure.Identity.Common;

/// <summary>
/// Static functions used from identity infrastructure.
/// </summary>
public static class StaticFunctions
{
    /// <summary>
    /// Generate random string used for refresh token string.
    /// </summary>
    /// <returns></returns>
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