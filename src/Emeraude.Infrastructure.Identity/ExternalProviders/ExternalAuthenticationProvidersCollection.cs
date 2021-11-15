using System.Collections.Generic;
using System.Linq;

namespace Emeraude.Infrastructure.Identity.ExternalProviders
{
    /// <inheritdoc />
    public class ExternalAuthenticationProvider : IExternalAuthenticationProvider
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalAuthenticationProvider"/> class.
        /// </summary>
        /// <param name="externalProviderAuthenticatorFactory"></param>
        public ExternalAuthenticationProvider(IExternalProviderAuthenticatorFactory externalProviderAuthenticatorFactory)
        {
            this.ExternalProviders = externalProviderAuthenticatorFactory.Providers?.Select(x => x.Name) ?? new List<string>();
        }

        /// <inheritdoc />
        public IEnumerable<string> ExternalProviders { get; }
    }
}