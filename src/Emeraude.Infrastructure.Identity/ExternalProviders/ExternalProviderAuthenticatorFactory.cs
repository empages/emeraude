using System.Collections.Generic;
using System.Linq;

namespace Emeraude.Infrastructure.Identity.ExternalProviders
{
    /// <inheritdoc />
    public class ExternalProviderAuthenticatorFactory : IExternalProviderAuthenticatorFactory
    {
        private readonly List<IExternalProviderAuthenticator> authenticators;

        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalProviderAuthenticatorFactory"/> class.
        /// </summary>
        /// <param name="authenticators"></param>
        public ExternalProviderAuthenticatorFactory(List<IExternalProviderAuthenticator> authenticators)
        {
            this.authenticators = authenticators;
        }

        /// <inheritdoc />
        public IEnumerable<IExternalProviderAuthenticator> Providers => this.authenticators;

        /// <inheritdoc />
        public IExternalProviderAuthenticator GetAuthenticator(string externalProvider)
        {
            return this.authenticators.FirstOrDefault(x => x.Name == externalProvider);
        }

        /// <inheritdoc />
        public bool ContainsProvider(string externalProvider)
        {
            return this.authenticators.Any(x => x.Name == externalProvider);
        }
    }
}