namespace Definux.Emeraude.Application.Identity.Requests.Commands.ExternalAuthentication
{
    /// <summary>
    /// Definition of external login request of Emeraude client authentication.
    /// </summary>
    public class ExternalAuthenticationData
    {
        /// <summary>
        /// External login provider.
        /// </summary>
        public string Provider { get; set; }

        /// <summary>
        /// Access token of the login provider.
        /// </summary>
        public string AccessToken { get; set; }
    }
}
