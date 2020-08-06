using Definux.Utilities.Objects;

namespace Definux.Emeraude.Application.Requests.Identity.Commands.ConfirmEmail
{
    public class ConfirmEmailRequestResult : SimpleResult
    {
        public ConfirmEmailRequestResult(bool success)
            : base(success)
        {

        }
    }
}
