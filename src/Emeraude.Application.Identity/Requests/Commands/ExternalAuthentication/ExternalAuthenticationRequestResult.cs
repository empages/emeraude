using Emeraude.Contracts;
using Microsoft.AspNetCore.Identity;

namespace Emeraude.Application.Identity.Requests.Commands.ExternalAuthentication
{
    /// <summary>
    /// Result of external authentication request.
    /// </summary>
    public class ExternalAuthenticationRequestResult
    {
        /// <summary>
        /// Result of the authentication.
        /// </summary>
        public SignInResult Result { get; set; }

        /// <summary>
        /// Authenticated user.
        /// </summary>
        public IUser User { get; set; }
    }
}
