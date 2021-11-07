using Definux.Utilities.Objects;

namespace Definux.Emeraude.Infrastructure.Identity.Models
{
    /// <summary>
    /// Bearer authentication simple result for API authentication request.
    /// </summary>
    public class BearerAuthenticationSimpleResult : SimpleResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BearerAuthenticationSimpleResult"/> class.
        /// </summary>
        /// <param name="succeeded"></param>
        public BearerAuthenticationSimpleResult(bool succeeded)
            : base(succeeded)
        {
        }

        /// <summary>
        /// Message of the result.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Access token.
        /// </summary>
        public string AccessToken { get; set; }
    }
}
