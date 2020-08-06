using Definux.Emeraude.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Definux.Emeraude.Application.Requests.Identity.Commands.LoginWithTwoFactorAuthentication
{
    public class LoginWithTwoFactorAuthenticationRequestResult
    {
        public SignInResult Result { get; set; }

        public IUser User { get; set; }
    }
}
