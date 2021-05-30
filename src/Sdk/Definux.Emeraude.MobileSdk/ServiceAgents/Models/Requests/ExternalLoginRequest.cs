using Definux.Emeraude.Interfaces.Requests;
using Newtonsoft.Json;

namespace Definux.Emeraude.MobileSdk.ServiceAgents.Models.Requests
{
    /// <inheritdoc />
    public class ExternalLoginRequest : IExternalLoginRequest
    {
        /// <summary>
        /// External login provider name.
        /// </summary>
        public string Provider { get; set; }

        /// <summary>
        /// External login provider access token.
        /// </summary>
        public string AccessToken { get; set; }
    }
}
