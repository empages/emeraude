namespace Definux.Emeraude.Presentation.PortalGateway.Models
{
    /// <summary>
    /// Wrapped response from the gateway connectivity check.
    /// </summary>
    public class GatewayResponse
    {
        /// <summary>
        /// Gets the verification status of the response.
        /// </summary>
        public bool Verified { get; set; }

        /// <summary>
        /// Current application environment variable.
        /// </summary>
        public string Environment { get; set; }
    }
}