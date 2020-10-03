using System;
using System.Net.Http;
using System.Threading.Tasks;
using Definux.Emeraude.MobileSdk.ServiceAgents.Settings;

namespace Definux.Emeraude.MobileSdk.ServiceAgents.Http
{
    /// <inheritdoc cref="IHttpClientFactory"/>
    public class HttpClientFactory : IHttpClientFactory
    {
        private readonly IRequestHeaderHelper requestHeaderHelper;

        /// <summary>
        /// Initializes a new instance of the <see cref="HttpClientFactory"/> class.
        /// </summary>
        /// <param name="requestHeaderHelper"></param>
        public HttpClientFactory(IRequestHeaderHelper requestHeaderHelper)
        {
            this.requestHeaderHelper = requestHeaderHelper;
        }

        /// <summary>
        /// Event which is triggered when the HTTP client is created.
        /// </summary>
        public event Action<HttpClient> AfterClientCreated;

        /// <inheritdoc/>
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
                BaseAddress = new Uri(settings.Url),
            };

            await this.requestHeaderHelper.InitializeHeadersAsync(client, settings);
            this.AfterClientCreated?.Invoke(client);

            return client;
        }
    }
}
