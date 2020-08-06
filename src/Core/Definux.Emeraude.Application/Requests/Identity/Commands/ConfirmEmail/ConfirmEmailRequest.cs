namespace Definux.Emeraude.Application.Requests.Identity.Commands.ConfirmEmail
{
    public class ConfirmEmailRequest
    {
        public string Email { get; set; }

        public string Token { get; set; }
    }
}
