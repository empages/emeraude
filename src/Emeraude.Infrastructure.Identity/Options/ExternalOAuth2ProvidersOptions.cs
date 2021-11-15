using System.Collections.Generic;
using System.Linq;

namespace Emeraude.Infrastructure.Identity.Options
{
    /// <summary>
    /// Implementation of external OAuth2 provider options.
    /// </summary>
    public class ExternalOAuth2ProvidersOptions : List<OAuth2Settings>
    {
        /// <summary>
        /// Returns the <see cref="OAuth2Settings"/> by specified provider name.
        /// </summary>
        /// <param name="providerName"></param>
        /// <returns></returns>
        public OAuth2Settings GetOauth2Settings(string providerName) => this.FirstOrDefault(x => x.Name == providerName);
    }
}