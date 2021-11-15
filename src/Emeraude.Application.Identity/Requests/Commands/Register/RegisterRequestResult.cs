using Emeraude.Contracts;
using Microsoft.AspNetCore.Identity;

namespace Emeraude.Application.Identity.Requests.Commands.Register
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
