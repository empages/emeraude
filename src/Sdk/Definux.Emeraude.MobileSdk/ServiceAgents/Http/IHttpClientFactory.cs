using System.Net.Http;
using System.Threading.Tasks;
using Definux.Emeraude.MobileSdk.ServiceAgents.Settings;

namespace Definux.Emeraude.MobileSdk.ServiceAgents.Http
{
    /// <summary>
    /// Factory for creating HTTP client with all application settings.
    /// </summary>
    public interface IHttpClientFactory
    {
        /// <summary>
        /// Creates a HTTP client configured with connected web API.
        /// </summary>
        /// <param name="settings"></param>
        /// <returns></returns>
        Task<HttpClient> CreateClientAsync(HostSettings settings);
    }
}
