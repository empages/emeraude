using Definux.Emeraude.MobileSdk.Configuration;
using Definux.Emeraude.MobileSdk.Constants;
using Definux.Emeraude.MobileSdk.ServiceAgents.Settings;
using Definux.Emeraude.MobileSdk.Stores;
using Definux.Emeraude.Resources;
using Plugin.DeviceInfo;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace Definux.Emeraude.MobileSdk.ServiceAgents.Http
{
    public class RequestHeaderHelper : IRequestHeaderHelper
    {
        private readonly ISystemSettingsStore systemSettingsStore;
        private readonly IEmConfiguration configuration;

        public RequestHeaderHelper(
            ISystemSettingsStore systemSettingsStore,
            IEmConfiguration configuration)
        {
            this.systemSettingsStore = systemSettingsStore;
            this.configuration = configuration;
        }

        public async Task InitializeHeadersAsync(HttpClient client, HostSettings settings)
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            client.DefaultRequestHeaders.Add(HeaderKeys.MobileRequest, bool.TrueString);
            client.DefaultRequestHeaders.Add(HeaderKeys.MobileDevice, CrossDeviceInfo.Current.DeviceName.ToString());
            client.DefaultRequestHeaders.Add(HeaderKeys.MobileManufacturer, CrossDeviceInfo.Current.Manufacturer.ToString());
            client.DefaultRequestHeaders.Add(HeaderKeys.MobileModel, CrossDeviceInfo.Current.Model.ToString());
            client.DefaultRequestHeaders.Add(HeaderKeys.MobilePlatform, CrossDeviceInfo.Current.Platform.ToString());
            client.DefaultRequestHeaders.Add(HeaderKeys.MobileVersion, CrossDeviceInfo.Current.Version.ToString());
            client.DefaultRequestHeaders.Add(HeaderKeys.MobileApplicationVersion, CrossDeviceInfo.Current.AppVersion.ToString());
            client.DefaultRequestHeaders.Add(HeaderKeys.ApplicationLanguage, this.systemSettingsStore.SelectedLanguage.Code);

            client = await SetBearerAuthHeaderAsync(client);

            if (settings.Headers != null && settings.Headers.Count > 0)
            {
                foreach (var header in settings?.Headers)
                {
                    client.DefaultRequestHeaders.Add(header.Key, header.Value);
                }
            }
        }

        private async Task<HttpClient> SetBearerAuthHeaderAsync(HttpClient client)
        {
            string accessToken = await SecureStorage.GetAsync(Tokens.AccessTokenString);
            if (!string.IsNullOrEmpty(accessToken))
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
            }

            return client;
        }
    }
}
