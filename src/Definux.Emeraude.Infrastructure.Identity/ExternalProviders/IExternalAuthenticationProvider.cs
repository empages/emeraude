using System.Collections.Generic;

namespace Definux.Emeraude.Infrastructure.Identity.ExternalProviders
{
    /// <summary>
    /// External authentication provider service.
    /// </summary>
    public interface IExternalAuthenticationProvider
    {
        /// <summary>
        /// Collection of external providers names.
        /// </summary>
        IEnumerable<string> ExternalProviders { get; }
    }
}