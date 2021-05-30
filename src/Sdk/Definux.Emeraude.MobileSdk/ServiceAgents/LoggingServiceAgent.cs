using Definux.Emeraude.MobileSdk.Configuration;
using Definux.Emeraude.MobileSdk.ServiceAgents.Http;

namespace Definux.Emeraude.MobileSdk.ServiceAgents
{
    /// <inheritdoc cref="ILoggingServiceAgent"/>
    public class LoggingServiceAgent : ServiceAgent, ILoggingServiceAgent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoggingServiceAgent"/> class.
        /// </summary>
        /// <param name="configuration"></param>
        /// <param name="clientFactory"></param>
        public LoggingServiceAgent(
            IEmConfiguration configuration,
            IHttpClientFactory clientFactory)
            : base(configuration, clientFactory)
        {
        }
    }
}
