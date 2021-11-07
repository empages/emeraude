using Definux.Emeraude.Contracts;
using Microsoft.AspNetCore.Identity;

namespace Definux.Emeraude.Application.Identity.Requests.Commands.Login
{
    /// <summary>
    /// Result of the login command.
    /// </summary>
    public class LoginRequestResult
    {
        /// <summary>
        /// Status of the result.
        /// </summary>
        public SignInResult Result { get; set; }

        /// <summary>
        /// Target user.
        /// </summary>
        public IUser User { get; set; }
    }
}
