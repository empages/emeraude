using Definux.Utilities.Objects;

namespace Definux.Emeraude.Application.Requests.Identity.Commands.ChangePassword
{
    public class ChangePasswordRequestResult : SimpleResult
    {
        public ChangePasswordRequestResult(bool success = false)
            : base(success)
        {

        }
    }
}
