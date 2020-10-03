using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Definux.Emeraude.Admin.UI.ViewModels.Manage
{
    /// <summary>
    /// ViewModel for activation of admin two factor authentication.
    /// </summary>
    public class AdminTwoFactorAuthenticationViewModel
    {
        /// <summary>
        /// Flag that indicates the current admin has two factor authenticator or not.
        /// </summary>
        public bool HasAuthenticator { get; set; }

        /// <summary>
        /// Flag that indicates the current user has enabled two factor authentication or not.
        /// </summary>
        public bool Is2faEnabled { get; set; }

        /// <summary>
        /// Two factor authenticator code.
        /// </summary>
        [Required]
        [StringLength(7, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        public string Code { get; set; }

        /// <summary>
        /// Key used for manual two factor authentication activation without a QR key.
        /// </summary>
        [BindNever]
        public string SharedKey { get; set; }

        /// <summary>
        /// Two factor authenticator code used for QR code generation.
        /// </summary>
        [BindNever]
        public string AuthenticatorUri { get; set; }
    }
}
