using System;
using System.Collections.Generic;
using System.Text;

namespace Definux.Emeraude.Interfaces.Results
{
    /// <summary>
    /// Interface that defines the required fields for bearer authentication result.
    /// </summary>
    public interface IBearerAuthenticationResult
    {
        /// <summary>
        /// Indicates the success status of the result.
        /// </summary>
        bool Success { get; set; }

        /// <summary>
        /// Message of the result.
        /// </summary>
        string Message { get; set; }

        /// <summary>
        /// Json web token.
        /// </summary>
        string JsonWebToken { get; set; }

        /// <summary>
        /// Refresh token.
        /// </summary>
        string RefreshToken { get; set; }
    }
}
