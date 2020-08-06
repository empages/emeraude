using Definux.Emeraude.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace Definux.Emeraude.Application.Requests.Identity.Commands.Register
{
    public class RegisterRequestResult
    {
        public IdentityResult Result { get; set; }

        public IUser User { get; set; }
    }
}
