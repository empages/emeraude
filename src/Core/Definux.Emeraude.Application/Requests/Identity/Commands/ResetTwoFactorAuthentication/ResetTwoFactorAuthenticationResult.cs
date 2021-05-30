using Definux.Utilities.Objects;

namespace Definux.Emeraude.Application.Requests.Identity.Commands.ResetTwoFactorAuthentication
{
    /// <summary>
    /// Reset two factor authenticator command result.
    /// </summary>
    public class ResetTwoFactorAuthenticationResult : SimpleResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResetTwoFactorAuthenticationResult"/> class.
        /// </summary>
        /// <param name="success"></param>
        public ResetTwoFactorAuthenticationResult(bool success = false)
            : base(success)
        {
        }
    }
}
