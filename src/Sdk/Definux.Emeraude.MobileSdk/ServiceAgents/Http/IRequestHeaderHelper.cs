using Definux.Emeraude.MobileSdk.ServiceAgents.Settings;
using System.Net.Http;
using System.Threading.Tasks;

namespace Definux.Emeraude.MobileSdk.ServiceAgents.Http
{
    public interface IRequestHeaderHelper
    {
        Task InitializeHeadersAsync(HttpClient client, HostSettings settings);
    }
}
