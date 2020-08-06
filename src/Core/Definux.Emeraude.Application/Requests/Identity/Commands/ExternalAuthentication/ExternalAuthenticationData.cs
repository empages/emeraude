using Definux.Emeraude.Interfaces.Requests;

namespace Definux.Emeraude.Application.Requests.Identity.Commands.ExternalAuthentication
{
    public class ExternalAuthenticationData : IExternalLoginRequest
    {
        public string Provider { get; set; }

        public string AccessToken { get; set; }
    }
}
