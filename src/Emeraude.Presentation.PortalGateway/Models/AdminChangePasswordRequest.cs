namespace Emeraude.Presentation.PortalGateway.Models
{
    /// <summary>
    /// Change password request model.
    /// </summary>
    public class AdminChangePasswordRequest
    {
        /// <summary>
        /// Current password.
        /// </summary>
        public string CurrentPassword { get; set; }

        /// <summary>
        /// The new password.
        /// </summary>
        public string NewPassword { get; set; }

        /// <summary>
        /// Confirmed new password.
        /// </summary>
        public string ConfirmedPassword { get; set; }
    }
}
