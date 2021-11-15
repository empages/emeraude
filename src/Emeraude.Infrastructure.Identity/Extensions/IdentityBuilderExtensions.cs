using Emeraude.Infrastructure.Identity.TokenProviders;
using Microsoft.AspNetCore.Identity;

namespace Emeraude.Infrastructure.Identity.Extensions
{
    /// <summary>
    /// Extensions for <see cref="IdentityBuilder"/>
    /// </summary>
    public static class IdentityBuilderExtensions
    {
        /// <summary>
        /// Register Emeraude default post authentication token provider.
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        public static IdentityBuilder AddEmPostAuthenticationTokenProvider(this IdentityBuilder builder)
        {
            return builder.AddTokenProvider(EmPostAuthenticationTokenProvider.ProviderName, typeof(EmPostAuthenticationTokenProvider));
        }
    }
}