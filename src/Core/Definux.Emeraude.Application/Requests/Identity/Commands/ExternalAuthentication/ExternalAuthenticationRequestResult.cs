using Definux.Emeraude.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace Definux.Emeraude.Application.Requests.Identity.Commands.ExternalAuthentication
{
    public class ExternalAuthenticationRequestResult
    {
        public SignInResult Result { get; set; }

        public IUser User { get; set; }
    }
}
