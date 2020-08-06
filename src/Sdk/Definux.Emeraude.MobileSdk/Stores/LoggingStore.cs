using Definux.Emeraude.MobileSdk.ServiceAgents;

namespace Definux.Emeraude.MobileSdk.Stores
{
    public class LoggingStore : Store, ILoggingStore
    {
        public LoggingStore(ILoggingServiceAgent loggingServiceAgent) 
            : base(loggingServiceAgent)
        {

        }
    }
}
