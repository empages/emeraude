using System.Linq;
using Definux.Emeraude.Essentials.Base;
using Definux.Emeraude.Essentials.Models;
using Microsoft.AspNetCore.Authorization;

namespace Definux.Emeraude.Admin.Extensions
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
        /// <returns></returns>
        public static AuthorizationOptions ApplyEmeraudeAdminAuthorizationPolicies(this AuthorizationOptions options)
        {
            foreach (ApplicationPermission permission in EmPermissions.AllPermissions)
            {
                options.AddPolicy(permission.Name, policy =>
                {
                    policy.AuthenticationSchemes.Add(EmAuthenticationDefaults.AdminAuthenticationScheme);
                    policy.RequireAuthenticatedUser();
                    policy.RequireClaim(EmClaimTypes.Permission, permission.Value);
                });
            }

            return options;
        }
    }
}
