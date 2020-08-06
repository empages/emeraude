using System;
using System.Collections.Generic;
using System.Text;

namespace Definux.Emeraude.Application.Requests.Identity.Commands.Register
{
    public class RegisterRequest
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string ConfirmedPassword { get; set; }
    }
}
