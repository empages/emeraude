using System.ComponentModel.DataAnnotations;

namespace Definux.Emeraude.Admin.UI.ViewModels.Manage
{
    public class AdminChangePasswordViewModel
    {
        public string CurrentPassword { get; set; }

        public string NewPassword { get; set; }

        public string ConfirmedPassword { get; set; }
    }
}
