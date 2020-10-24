using System;
using Definux.Emeraude.Interfaces.Requests;

namespace Definux.Emeraude.Application.Requests.Identity.Commands.ChangePassword
{
    /// <inheritdoc cref="IChangePasswordRequest"/>
    public class ChangePasswordRequest : IChangePasswordRequest
    {
        /// <inheritdoc/>
        public Guid UserId { get; set; }

        /// <inheritdoc/>
        public string CurrentPassword { get; set; }

        /// <inheritdoc/>
        public string NewPassword { get; set; }

        /// <inheritdoc/>
        public string ConfirmedPassword { get; set; }
    }
}
