using System;
using System.Collections.Generic;
using Definux.Emeraude.MobileSdk.ServiceAgents.Settings;
using Xamarin.Essentials;

namespace Definux.Emeraude.MobileSdk.Configuration
{
    /// <inheritdoc cref="IEmConfiguration"/>
    public abstract class EmConfiguration : IEmConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmConfiguration"/> class.
        /// </summary>
        /// <param name="rootBaseUrl"></param>
        public EmConfiguration(string rootBaseUrl)
        {
            if (string.IsNullOrEmpty(rootBaseUrl))
            {
                throw new ArgumentNullException(rootBaseUrl);
            }

            this.RootBaseUrl = rootBaseUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmConfiguration"/> class.
        /// </summary>
        /// <param name="hostMachineIp"></param>
        /// <param name="addressPort"></param>
        /// <param name="useHttps"></param>
        public EmConfiguration(string hostMachineIp, string addressPort, bool useHttps = true)
        {
            if (string.IsNullOrEmpty(hostMachineIp))
            {
                throw new ArgumentNullException(hostMachineIp);
            }

            if (string.IsNullOrEmpty(addressPort))
            {
                throw new ArgumentNullException(addressPort);
            }

            string rootBaseUrlTemplate = $"http{(useHttps ? "s" : string.Empty)}://{{0}}:{addressPort}";

            if (DeviceInfo.DeviceType == DeviceType.Virtual)
            {
                string ipAddress = DeviceInfo.Platform == DevicePlatform.Android ? "10.0.2.2" : "localhost";
                this.RootBaseUrl = string.Format(rootBaseUrlTemplate, ipAddress);
            }
            else if (DeviceInfo.DeviceType == DeviceType.Physical || DeviceInfo.DeviceType == DeviceType.Unknown)
            {
                this.RootBaseUrl = string.Format(rootBaseUrlTemplate, hostMachineIp);
            }
        }

        /// <inheritdoc/>
        public string RootBaseUrl { get; }

        /// <inheritdoc/>
        public Dictionary<string, string> Headers { get; protected set; }

        /// <inheritdoc/>
        public string FacebookAppId { get; protected set; }

        /// <inheritdoc/>
        public string GoogleClientId { get; protected set; }

        /// <inheritdoc/>
        public string FacebookRedirectUrl
        {
            get
            {
                if (!string.IsNullOrEmpty(this.FacebookAppId))
                {
                    return $"fb{this.FacebookAppId}://authorize";
                }

                return "/";
            }
        }

        /// <inheritdoc/>
        public string GoogleRedirectUrl
        {
            get
            {
                if (!string.IsNullOrEmpty(this.GoogleClientId))
                {
                    var clientElements = this.GoogleClientId.Split('.');
                    Array.Reverse(clientElements);

                    return $"{string.Join(".", clientElements)}:/oauth2redirect";
                }

                return "/";
            }
        }

        /// <inheritdoc/>
        public HostSettings ToHostSettings()
        {
            return new HostSettings
            {
                Headers = this.Headers,
                Url = $"{this.RootBaseUrl}/",
            };
        }

        /// <inheritdoc/>
        public string GetValueBasedOnDevicePlatform(string androidValue, string iOSValue)
        {
            if (DeviceInfo.Platform == DevicePlatform.Android)
            {
                return androidValue;
            }
            else if (DeviceInfo.Platform == DevicePlatform.iOS)
            {
                return iOSValue;
            }

            return string.Empty;
        }
    }
}
