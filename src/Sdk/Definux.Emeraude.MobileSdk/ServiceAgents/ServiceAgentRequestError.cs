using System;
using System.Collections.Generic;
using System.Text;

namespace Definux.Emeraude.MobileSdk.ServiceAgents
{
    public class ServiceAgentRequestError
    {
        public ServiceAgentRequestError()
            : this(Guid.NewGuid())
        {

        }

        public ServiceAgentRequestError(Dictionary<string, IEnumerable<string>> extraParameters = null)
            : this(Guid.NewGuid(), extraParameters)
        { }

        public ServiceAgentRequestError(Guid identifier, Dictionary<string, IEnumerable<string>> extraParameters = null)
        {
            if (identifier == default(Guid))
            {
                throw new ArgumentException("An empty Guid is not allowed", nameof(identifier));
            }

            Identifier = identifier;
            ExtraParameters = extraParameters ?? new Dictionary<string, IEnumerable<string>>();
        }

        public Guid Identifier { get; set; }

        public Uri Type { get; set; }

        public string Title { get; set; }

        public int Status { get; set; }

        public string Code { get; set; }

        public Dictionary<string, IEnumerable<string>> ExtraParameters { get; set; }
    }
}
