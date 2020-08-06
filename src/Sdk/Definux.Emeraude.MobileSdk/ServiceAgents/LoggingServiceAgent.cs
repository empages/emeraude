using Definux.Emeraude.MobileSdk.Configuration;
using Definux.Emeraude.MobileSdk.ServiceAgents.Http;

namespace Definux.Emeraude.MobileSdk.ServiceAgents
{
    public class LoggingServiceAgent : ServiceAgent, ILoggingServiceAgent
    {
        public LoggingServiceAgent(
            IEmConfiguration configuration,
            IHttpClientFactory clientFactory)
            : base(configuration, clientFactory)
        {

        }
    }
}
