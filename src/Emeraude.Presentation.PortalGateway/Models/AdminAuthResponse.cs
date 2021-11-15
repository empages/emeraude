using Emeraude.Infrastructure.Identity.Models;

namespace Emeraude.Presentation.PortalGateway.Models
{
    /// <summary>
    /// Response of admin authentication process.
    /// </summary>
    public class AdminAuthResponse : BearerAuthenticationSimpleResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdminAuthResponse"/> class.
        /// </summary>
        /// <param name="simpleResult"></param>
        public AdminAuthResponse(BearerAuthenticationSimpleResult simpleResult)
            : base(simpleResult.Succeeded)
        {
            this.Message = simpleResult.Message;
            this.AccessToken = simpleResult.AccessToken;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminAuthResponse"/> class.
        /// </summary>
        /// <param name="succeeded"></param>
        public AdminAuthResponse(bool succeeded)
            : base(succeeded)
        {
        }

        /// <summary>
        /// Post authentication token used for two factor authentication cache.
        /// </summary>
        public string PostAuthenticationToken { get; set; }

        /// <summary>
        /// Indicates whether the authentication require additional factor to be completely successful.
        /// </summary>
        public bool RequiresAdditionalAuthenticationFactor => !string.IsNullOrWhiteSpace(this.PostAuthenticationToken);
    }
}