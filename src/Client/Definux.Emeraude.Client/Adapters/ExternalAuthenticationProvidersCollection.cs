using System.Collections.Generic;
using System.Linq;
using Definux.Emeraude.Application.Identity;
using Definux.Emeraude.Client.UI.Adapters;

namespace Definux.Emeraude.Client.Adapters
{
    /// <inheritdoc />
    public class ExternalAuthenticationProvidersCollection : IExternalAuthenticationProvidersCollection
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalAuthenticationProvidersCollection"/> class.
        /// </summary>
        /// <param name="externalProviderAuthenticatorFactory"></param>
        public ExternalAuthenticationProvidersCollection(IExternalProviderAuthenticatorFactory externalProviderAuthenticatorFactory)
        {
            this.ExternalProviders = externalProviderAuthenticatorFactory.Providers?.Select(x => x.Name) ?? new List<string>();
        }

        /// <inheritdoc />
        public IEnumerable<string> ExternalProviders { get; }
    }
}