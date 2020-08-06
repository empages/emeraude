using Definux.Emeraude.MobileSdk.ServiceAgents.Settings;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Definux.Emeraude.MobileSdk.ServiceAgents.Http
{
    public class HttpClientFactory : IHttpClientFactory
    {
        private readonly IRequestHeaderHelper requestHeaderHelper;

        public event Action<HttpClient> AfterClientCreated;

        public HttpClientFactory(IRequestHeaderHelper requestHeaderHelper)
        {
            this.requestHeaderHelper = requestHeaderHelper;
        }

        public async Task<HttpClient> CreateClientAsync(HostSettings settings)
        {
            HttpClientHandler httpClientHandler = null;
#if DEBUG
            httpClientHandler = new HttpClientHandler()
            {
                ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) =>
                {
                    var auth = sender?.Headers?.Authorization;
                    return true;
                },

            };
#endif

            var client = new HttpClient(httpClientHandler, httpClientHandler != null)
            {
                BaseAddress = new Uri(settings.Url)
            };

            await this.requestHeaderHelper.InitializeHeadersAsync(client, settings);
            AfterClientCreated?.Invoke(client);

            return client;
        }
    }
}
