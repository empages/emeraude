using Definux.Utilities.Objects;

namespace Definux.Emeraude.Application.Requests.Identity.Commands.ForgotPassword
{
    public class ForgotPasswordRequestResult : SimpleResult
    {
        public ForgotPasswordRequestResult(bool success)
            : base(success)
        {

        }
    }
}