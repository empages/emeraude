namespace Definux.Emeraude.Application.Requests.Identity.Queries.GetUserExternalLoginProviders
{
    /// <summary>
    /// Wrap for external login provider.
    /// </summary>
    public class UserExternalLoginProvider
    {
        /// <summary>
        /// External login provider.
        /// </summary>
        public string Provider { get; set; }

        /// <summary>
        /// External login provider display name.
        /// </summary>
        public string ProviderDisplayName { get; set; }
    }
}