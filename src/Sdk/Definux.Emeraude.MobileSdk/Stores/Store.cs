using Definux.Emeraude.MobileSdk.ServiceAgents;

namespace Definux.Emeraude.MobileSdk.Stores
{
    /// <summary>
    /// Abstract implementation of store for state management.
    /// </summary>
    public abstract class Store
    {
        private readonly ILoggingServiceAgent loggingServiceAgent;

        /// <summary>
        /// Initializes a new instance of the <see cref="Store"/> class.
        /// </summary>
        /// <param name="loggingServiceAgent"></param>
        public Store(ILoggingServiceAgent loggingServiceAgent)
        {
            this.loggingServiceAgent = loggingServiceAgent;
        }
    }
}
