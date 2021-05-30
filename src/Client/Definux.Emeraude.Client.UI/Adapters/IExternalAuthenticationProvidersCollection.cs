using System.Collections.Generic;

namespace Definux.Emeraude.Client.UI.Adapters
{
    /// <summary>
    /// Adapter provides access to a list of loaded external authentication providers.
    /// </summary>
    public interface IExternalAuthenticationProvidersCollection
    {
        /// <summary>
        /// Collection of external providers names.
        /// </summary>
        IEnumerable<string> ExternalProviders { get; }
    }
}