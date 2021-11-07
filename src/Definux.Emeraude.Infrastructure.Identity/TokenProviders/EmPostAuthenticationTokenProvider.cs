using System;
using Definux.Emeraude.Infrastructure.Identity.Entities;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Definux.Emeraude.Infrastructure.Identity.TokenProviders
{
    /// <summary>
    /// Default Emeraude post authentication token provider. This token provider is useful when authentication
    /// logic needs additional logic (Example: post authentication token is needed to keep the user logged in until
    /// he/she enter the 2FA code.
    /// </summary>
    public class EmPostAuthenticationTokenProvider : DataProtectorTokenProvider<User>
    {
        /// <summary>
        /// Name of the token provider.
        /// </summary>
        public const string ProviderName = "EmPostAuthenticator";

        /// <summary>
        /// Key of the token.
        /// </summary>
        public const string ProviderKey = "Post-Authentication-Token";

        private readonly TimeSpan lifespan = TimeSpan.FromMinutes(5);

        /// <summary>
        /// Initializes a new instance of the <see cref="EmPostAuthenticationTokenProvider"/> class.
        /// </summary>
        /// <param name="dataProtectionProvider"></param>
        /// <param name="options"></param>
        /// <param name="logger"></param>
        public EmPostAuthenticationTokenProvider(
            IDataProtectionProvider dataProtectionProvider,
            IOptions<DataProtectionTokenProviderOptions> options,
            ILogger<EmPostAuthenticationTokenProvider> logger)
            : base(dataProtectionProvider, options, logger)
        {
            options.Value.TokenLifespan = this.lifespan;
        }
    }
}