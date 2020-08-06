using Definux.Emeraude.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace Definux.Emeraude.Application.Requests.Identity.Commands.Login
{
    public class LoginRequestResult
    {
        public SignInResult Result { get; set; }

        public IUser User { get; set; }
    }
}
