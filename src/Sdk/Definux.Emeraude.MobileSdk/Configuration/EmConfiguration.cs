using Definux.Emeraude.MobileSdk.ServiceAgents.Settings;
using System;
using System.Collections.Generic;
using Xamarin.Essentials;

namespace Definux.Emeraude.MobileSdk.Configuration
{
    public abstract class EmConfiguration : IEmConfiguration
    {
        public EmConfiguration(string rootBaseUrl)
        {
            if (string.IsNullOrEmpty(rootBaseUrl))
            {
                throw new ArgumentNullException(rootBaseUrl);
            }
            RootBaseUrl = rootBaseUrl;
        }

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
                RootBaseUrl = string.Format(rootBaseUrlTemplate, ipAddress);
            }
            else if (DeviceInfo.DeviceType == DeviceType.Physical || DeviceInfo.DeviceType == DeviceType.Unknown)
            {
                RootBaseUrl = string.Format(rootBaseUrlTemplate, hostMachineIp);
            }
        }

        public string RootBaseUrl { get; }

        public Dictionary<string, string> Headers { get; protected set; }

        public string FacebookAppId { get; protected set; }

        public string GoogleClientId { get; protected set; }

        public string FacebookRedirectUrl
        {
            get
            {
                if (!string.IsNullOrEmpty(FacebookAppId))
                {
                    return $"fb{FacebookAppId}://authorize";
                }

                return "/";
            }
        }

        public string GoogleRedirectUrl
        {
            get
            {
                if (!string.IsNullOrEmpty(GoogleClientId))
                {
                    var clientElements = GoogleClientId.Split('.');
                    Array.Reverse(clientElements);

                    return $"{string.Join(".", clientElements)}:/oauth2redirect";
                }

                return "/";
            }
        }

        public HostSettings ToHostSettings()
        {
            return new HostSettings
            {
                Headers = Headers,
                Url = $"{RootBaseUrl}/"
            };
        }

        public string SetBasedOnDevicePlatform(string androidValue, string iOSValue)
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
