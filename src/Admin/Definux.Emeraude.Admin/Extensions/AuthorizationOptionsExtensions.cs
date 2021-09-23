using System.Linq;
using Definux.Emeraude.Configuration.Authorization;
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
            foreach (ApplicationPermission permission in AdminPermissions.AllPermissions)
            {
                options.AddPolicy(permission.Name, policy =>
                {
                    policy.AuthenticationSchemes.Add(AuthenticationDefaults.AdminAuthenticationScheme);
                    policy.RequireAuthenticatedUser();
                    policy.RequireClaim(ClaimTypes.Permission, permission.Value);
                });
            }

            return options;
        }
    }
}
