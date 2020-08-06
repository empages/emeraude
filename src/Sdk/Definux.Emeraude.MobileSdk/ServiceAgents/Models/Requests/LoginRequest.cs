using Definux.Emeraude.Interfaces.Requests;

namespace Definux.Emeraude.MobileSdk.ServiceAgents.Models.Requests
{
    public class LoginRequest : ILoginRequest
    {
        public string Email { get; set; }

        public string Password { get; set; }
    }
}
