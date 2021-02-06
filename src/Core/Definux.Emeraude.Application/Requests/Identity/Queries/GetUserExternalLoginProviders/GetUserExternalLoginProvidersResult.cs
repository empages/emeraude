using System.Collections.Generic;

namespace Definux.Emeraude.Application.Requests.Identity.Queries.GetUserExternalLoginProviders
{
    /// <summary>
    /// Result of <see cref="GetUserExternalLoginProvidersQuery"/>.
    /// </summary>
    public class GetUserExternalLoginProvidersResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetUserExternalLoginProvidersResult"/> class.
        /// </summary>
        public GetUserExternalLoginProvidersResult()
        {
            this.Providers = new List<UserExternalLoginProvider>();
        }

        /// <summary>
        /// Collection of user external login providers.
        /// </summary>
        public List<UserExternalLoginProvider> Providers { get; set; }
    }
}