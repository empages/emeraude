using Definux.Emeraude.MobileSdk.ServiceAgents.Settings;
using System.Net.Http;
using System.Threading.Tasks;

namespace Definux.Emeraude.MobileSdk.ServiceAgents.Http
{
    public interface IHttpClientFactory
    {
        Task<HttpClient> CreateClientAsync(HostSettings settings);
    }
}
