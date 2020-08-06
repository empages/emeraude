namespace Definux.Emeraude.Application.Requests.Identity.Commands.ResetPassword
{
    public class ResetPasswordRequest
    {
        public string Email { get; set; }

        public string Password { get; set; }

        public string ConfirmedPassword { get; set; }

        public string Token { get; set; }
    }
}
