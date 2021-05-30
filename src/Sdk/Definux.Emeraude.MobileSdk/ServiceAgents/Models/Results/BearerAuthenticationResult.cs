using Definux.Emeraude.Interfaces.Results;

namespace Definux.Emeraude.MobileSdk.ServiceAgents.Models.Results
{
    /// <inheritdoc />
    public class BearerAuthenticationResult : IBearerAuthenticationResult
    {
        /// <inheritdoc />
        public bool Success { get; set; }

        /// <inheritdoc />
        public string Message { get; set; }

        /// <inheritdoc />
        public string JsonWebToken { get; set; }

        /// <inheritdoc />
        public string RefreshToken { get; set; }
    }
}
