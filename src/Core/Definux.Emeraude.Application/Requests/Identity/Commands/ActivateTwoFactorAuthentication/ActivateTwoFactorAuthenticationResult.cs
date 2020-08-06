using Definux.Utilities.Objects;

namespace Definux.Emeraude.Application.Requests.Identity.Commands.ActivateTwoFactorAuthentication
{
    public class ActivateTwoFactorAuthenticationResult : SimpleResult
    {
        public ActivateTwoFactorAuthenticationResult(bool success)
            : base(success)
        {

        }
    }
}
