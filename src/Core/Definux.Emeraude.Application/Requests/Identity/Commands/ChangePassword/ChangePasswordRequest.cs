using System;

namespace Definux.Emeraude.Application.Requests.Identity.Commands.ChangePassword
{
    public class ChangePasswordRequest
    {
        public Guid UserId { get; set; }

        public string CurrentPassword { get; set; }

        public string NewPassword { get; set; }

        public string ConfirmedPassword { get; set; }
    }
}
