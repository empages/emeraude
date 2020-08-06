using Definux.Emeraude.Interfaces.Results;

namespace Definux.Emeraude.MobileSdk.ServiceAgents.Models.Results
{
    public class BearerAuthenticationResult : IBearerAuthenticationResult
    {
        public bool Success { get; set; }

        public string Message { get; set; }

        public string JsonWebToken { get; set; }

        public string RefreshToken { get; set; }
    }
}
