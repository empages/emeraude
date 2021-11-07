using Definux.Utilities.Objects;

namespace Definux.Emeraude.Application.Identity.Requests.Commands.ActivateTwoFactorAuthentication
{
    /// <summary>
    /// Result for two factor authentication request.
    /// </summary>
    public class ActivateTwoFactorAuthenticationResult : SimpleResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActivateTwoFactorAuthenticationResult"/> class.
        /// </summary>
        /// <param name="success"></param>
        public ActivateTwoFactorAuthenticationResult(bool success)
            : base(success)
        {
        }
    }
}
