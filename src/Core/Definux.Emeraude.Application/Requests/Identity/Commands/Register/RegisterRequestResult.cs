using Definux.Emeraude.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace Definux.Emeraude.Application.Requests.Identity.Commands.Register
{
    /// <summary>
    /// Result of the register request.
    /// </summary>
    public class RegisterRequestResult
    {
        /// <summary>
        /// <inheritdoc cref="IdentityResult"/>
        /// </summary>
        public IdentityResult Result { get; set; }

        /// <summary>
        /// Target user.
        /// </summary>
        public IUser User { get; set; }
    }
}
