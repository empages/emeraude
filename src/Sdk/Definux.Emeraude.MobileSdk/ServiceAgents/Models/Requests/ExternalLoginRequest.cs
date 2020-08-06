using Definux.Emeraude.Interfaces.Requests;
using Newtonsoft.Json;

namespace Definux.Emeraude.MobileSdk.ServiceAgents.Models.Requests
{
    public class ExternalLoginRequest : IExternalLoginRequest
    {
        public string Provider { get; set; }

        public string AccessToken { get; set; }
    }
}
