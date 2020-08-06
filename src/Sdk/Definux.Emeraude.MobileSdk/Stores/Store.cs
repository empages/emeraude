using Definux.Emeraude.MobileSdk.ServiceAgents;

namespace Definux.Emeraude.MobileSdk.Stores
{
    public abstract class Store
    {
        private readonly ILoggingServiceAgent loggingServiceAgent;

        public Store(ILoggingServiceAgent loggingServiceAgent)
        {
            this.loggingServiceAgent = loggingServiceAgent;
        }
    }
}
