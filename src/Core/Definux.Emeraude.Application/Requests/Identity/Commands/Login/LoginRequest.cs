using Definux.Emeraude.Interfaces.Requests;

namespace Definux.Emeraude.Application.Requests.Identity.Commands.Login
{
    public class LoginRequest : ILoginRequest
    {
        public string Email { get; set; }

        public string Password { get; set; }
    }
}
