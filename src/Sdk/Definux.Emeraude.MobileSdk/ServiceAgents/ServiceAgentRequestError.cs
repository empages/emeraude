using System;
using System.Collections.Generic;

namespace Definux.Emeraude.MobileSdk.ServiceAgents
{
    /// <summary>
    /// Service agent request error implementation used for error encapsulation.
    /// </summary>
    public class ServiceAgentRequestError
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceAgentRequestError"/> class.
        /// </summary>
        public ServiceAgentRequestError()
            : this(Guid.NewGuid())
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceAgentRequestError"/> class.
        /// </summary>
        /// <param name="extraParameters"></param>
        public ServiceAgentRequestError(Dictionary<string, IEnumerable<string>> extraParameters = null)
            : this(Guid.NewGuid(), extraParameters)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceAgentRequestError"/> class.
        /// </summary>
        /// <param name="identifier"></param>
        /// <param name="extraParameters"></param>
        public ServiceAgentRequestError(Guid identifier, Dictionary<string, IEnumerable<string>> extraParameters = null)
        {
            if (identifier == default(Guid))
            {
                throw new ArgumentException("An empty Guid is not allowed", nameof(identifier));
            }

            this.Identifier = identifier;
            this.ExtraParameters = extraParameters ?? new Dictionary<string, IEnumerable<string>>();
        }

        /// <summary>
        /// Identifier of the error.
        /// </summary>
        public Guid Identifier { get; set; }

        /// <summary>
        /// Url of the error.
        /// </summary>
        public Uri Type { get; set; }

        /// <summary>
        /// Title of the error.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Status code of the error.
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// Code of the error.
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Extra parameters for more details about the error.
        /// </summary>
        public Dictionary<string, IEnumerable<string>> ExtraParameters { get; set; }
    }
}
