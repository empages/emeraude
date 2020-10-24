using System;
using System.Collections.Generic;
using System.Text;

namespace Definux.Emeraude.Interfaces.Requests
{
    /// <summary>
    /// Definition of register request of Emeraude client authentication.
    /// </summary>
    public interface IRegisterRequest
    {
        /// <summary>
        /// Name of the user.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Email of the user.
        /// </summary>
        string Email { get; set; }

        /// <summary>
        /// Password of the user.
        /// </summary>
        string Password { get; set; }

        /// <summary>
        /// Confirmed password of the user.
        /// </summary>
        string ConfirmedPassword { get; set; }
    }
}
