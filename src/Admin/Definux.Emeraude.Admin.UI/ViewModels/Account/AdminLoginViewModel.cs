using System.ComponentModel.DataAnnotations;

namespace Definux.Emeraude.Admin.UI.ViewModels.Account
{
    /// <summary>
    /// View model that defines the login form for admin authentication.
    /// </summary>
    public class AdminLoginViewModel
    {
        /// <summary>
        /// Email address of the admin user.
        /// </summary>
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        /// <summary>
        /// Password of the admin user.
        /// </summary>
        [Required]
        public string Password { get; set; }
    }
}
