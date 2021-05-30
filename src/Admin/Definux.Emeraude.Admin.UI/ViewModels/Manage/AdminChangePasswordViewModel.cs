using System.ComponentModel.DataAnnotations;

namespace Definux.Emeraude.Admin.UI.ViewModels.Manage
{
    /// <summary>
    /// View model for changing administrator password.
    /// </summary>
    public class AdminChangePasswordViewModel
    {
        /// <summary>
        /// Current password.
        /// </summary>
        public string CurrentPassword { get; set; }

        /// <summary>
        /// New password.
        /// </summary>
        public string NewPassword { get; set; }

        /// <summary>
        /// Confirmed new password.
        /// </summary>
        public string ConfirmedPassword { get; set; }
    }
}
