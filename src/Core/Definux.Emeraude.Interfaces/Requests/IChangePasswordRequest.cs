using System;

namespace Definux.Emeraude.Interfaces.Requests
{
    /// <summary>
    /// Definition of change password request.
    /// </summary>
    public interface IChangePasswordRequest
    {
        /// <summary>
        /// Id of the user.
        /// </summary>
        Guid UserId { get; set; }

        /// <summary>
        /// Current password of the user.
        /// </summary>
        string CurrentPassword { get; set; }

        /// <summary>
        /// New password of the user.
        /// </summary>
        string NewPassword { get; set; }

        /// <summary>
        /// Confirmed new password of the user.
        /// </summary>
        string ConfirmedPassword { get; set; }
    }
}
