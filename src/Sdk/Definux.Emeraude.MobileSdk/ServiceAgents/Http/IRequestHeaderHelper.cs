using System.Net.Http;
using System.Threading.Tasks;
using Definux.Emeraude.MobileSdk.ServiceAgents.Settings;

namespace Definux.Emeraude.MobileSdk.ServiceAgents.Http
{
    /// <summary>
    /// Request header helper that modify HTTP client.
    /// </summary>
    public interface IRequestHeaderHelper
    {
        /// <summary>
        /// Apply specified <see cref="HostSettings"/> into <seealso cref="HttpClient"/>.
        /// </summary>
        /// <param name="client"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        Task InitializeHeadersAsync(HttpClient client, HostSettings settings);
    }
}
