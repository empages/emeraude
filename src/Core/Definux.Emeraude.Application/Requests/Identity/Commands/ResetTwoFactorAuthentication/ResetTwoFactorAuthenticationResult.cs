using Definux.Utilities.Objects;

namespace Definux.Emeraude.Application.Requests.Identity.Commands.ResetTwoFactorAuthentication
{
    public class ResetTwoFactorAuthenticationResult : SimpleResult
    {
        public ResetTwoFactorAuthenticationResult(bool success = false)
            : base(success)
        {

        }
    }
}
