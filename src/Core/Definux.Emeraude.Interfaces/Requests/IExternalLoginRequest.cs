namespace Definux.Emeraude.Interfaces.Requests
{
    /// <summary>
    /// Definition of external login request of Emeraude client authentication.
    /// </summary>
    public interface IExternalLoginRequest
    {
        /// <summary>
        /// External login provider.
        /// </summary>
        string Provider { get; set; }

        /// <summary>
        /// Access token of the login provider.
        /// </summary>
        string AccessToken { get; set; }
    }
}
