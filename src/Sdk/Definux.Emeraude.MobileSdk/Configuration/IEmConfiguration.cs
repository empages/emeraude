using System.Collections.Generic;
using Definux.Emeraude.MobileSdk.ServiceAgents.Settings;

namespace Definux.Emeraude.MobileSdk.Configuration
{
    /// <summary>
    /// Emeraude mobile SDK configuration definition.
    /// </summary>
    public interface IEmConfiguration
    {
        /// <summary>
        /// Headers which will be send on each request.
        /// </summary>
        Dictionary<string, string> Headers { get; }

        /// <summary>
        /// Web API base URL.
        /// </summary>
        string RootBaseUrl { get; }

        /// <summary>
        /// AppId for Facebook OAuth2 external authentication.
        /// </summary>
        string FacebookAppId { get; }

        /// <summary>
        /// ClientId for Google OAuth2 external authentication.
        /// </summary>
        string GoogleClientId { get; }

        /// <summary>
        /// Redirect URL for Facebook OAuth2 external authentication.
        /// </summary>
        string FacebookRedirectUrl { get; }

        /// <summary>
        /// Redirect URL for Google OAuth2 external authentication.
        /// </summary>
        string GoogleRedirectUrl { get; }

        /// <summary>
        /// Method that converts the configuration into host settings.
        /// </summary>
        /// <returns></returns>
        HostSettings ToHostSettings();

        /// <summary>
        /// Get value based on the current platform.
        /// </summary>
        /// <param name="androidValue"></param>
        /// <param name="iOSValue"></param>
        /// <returns></returns>
        string GetValueBasedOnDevicePlatform(string androidValue, string iOSValue);
    }
}
