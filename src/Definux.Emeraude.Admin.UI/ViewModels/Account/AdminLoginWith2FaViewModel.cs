using System.ComponentModel.DataAnnotations;

namespace Definux.Emeraude.Admin.UI.ViewModels.Account
{
    /// <summary>
    /// View model that defines the multi-factor login form for admin authentication.
    /// </summary>
    public class AdminLoginWith2FaViewModel
    {
        /// <summary>
        /// Two factor authentication code.
        /// </summary>
        [Required]
        [StringLength(7, ErrorMessage = "The authentication code must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Text)]
        public string TwoFactorCode { get; set; }
    }
}
