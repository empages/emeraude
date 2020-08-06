using Definux.Utilities.Objects;

namespace Definux.Emeraude.Application.Requests.Identity.Commands.ResetPassword
{
    public class ResetPasswordRequestResult : SimpleResult
    {
        public ResetPasswordRequestResult(bool success)
            : base(success)
        {

        }
    }
}
