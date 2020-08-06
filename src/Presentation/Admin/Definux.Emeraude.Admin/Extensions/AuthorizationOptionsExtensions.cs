using Definux.Emeraude.Configuration.Authorization;
using Microsoft.AspNetCore.Authorization;

namespace Definux.Emeraude.Admin.Extensions
{
    public static class AuthorizationOptionsExtensions
    {
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
