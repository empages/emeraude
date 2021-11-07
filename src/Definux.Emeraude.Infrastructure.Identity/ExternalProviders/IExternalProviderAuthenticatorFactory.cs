using System.Collections.Generic;

namespace Definux.Emeraude.Infrastructure.Identity.ExternalProviders
{
    /// <summary>
    /// Provides factory for getting an external provider authenticator.
    /// </summary>
    public interface IExternalProviderAuthenticatorFactory
    {
        /// <summary>
        /// Collection of all external providers.
        /// </summary>
        IEnumerable<IExternalProviderAuthenticator> Providers { get; }

        /// <summary>
        /// Returns external provider authenticator by specified provider name.
        /// </summary>
        /// <param name="externalProvider"></param>
        /// <returns></returns>
        IExternalProviderAuthenticator GetAuthenticator(string externalProvider);

        /// <summary>
        /// Returns boolean value that indicates whether the external provider is available or not.
        /// </summary>
        /// <param name="externalProvider"></param>
        /// <returns></returns>
        bool ContainsProvider(string externalProvider);
    }
}