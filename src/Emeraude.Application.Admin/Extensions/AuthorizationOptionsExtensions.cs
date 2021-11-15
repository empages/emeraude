using System.Linq;
using Emeraude.Essentials.Base;
using Emeraude.Essentials.Models;
using Microsoft.AspNetCore.Authorization;

namespace Emeraude.Application.Admin.Extensions
{
    /// <summary>
    /// Extensions for <see cref="AuthorizationOptions"/>.
    /// </summary>
    public static class AuthorizationOptionsExtensions
    {
        /// <summary>
        /// Apply authorization policies to administration.
        /// </summary>
        /// <param name="options"></param>
        public static void ApplyEmeraudeAdminAuthorizationPolicies(this AuthorizationOptions options)
        {
            foreach (ApplicationPermission permission in EmPermissions.AllPermissions)
            {
                options.AddPolicy(permission.Name, policy =>
                {
                    policy.AuthenticationSchemes.Add(EmAuthenticationDefaults.BearerAuthenticationScheme);
                    policy.RequireAuthenticatedUser();
                    policy.RequireClaim(EmClaimTypes.Permission, permission.Value);
                });
            }
        }
    }
}
