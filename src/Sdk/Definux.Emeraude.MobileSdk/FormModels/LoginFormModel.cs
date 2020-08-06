using Definux.Emeraude.MobileSdk.FormModels.Abstractions;
using Definux.Emeraude.MobileSdk.Helpers;

namespace Definux.Emeraude.MobileSdk.FormModels
{
    public class LoginFormModel : FormModel
    {
        private string email;
        private string password;

        private string emailErrorMessage;
        private string passwordErrorMessage;

        public string Email
        {
            get => this.email;
            set => SetProperty(ref this.email, value);
        }

        public string Password
        {
            get => this.password;
            set => SetProperty(ref this.password, value);
        }

        public string EmailErrorMessage
        {
            get => this.emailErrorMessage;
            set => SetProperty(ref this.emailErrorMessage, value);
        }

        public string PasswordErrorMessage
        {
            get => this.passwordErrorMessage;
            set => SetProperty(ref this.passwordErrorMessage, value);
        }

        public override bool IsValid()
        {
            bool correctData = true;
            EmailErrorMessage = null;
            PasswordErrorMessage = null;
            string errorMessage = null;
            if (!Validators.IsValidEmail(Email, out errorMessage))
            {
                EmailErrorMessage = errorMessage;
                correctData = false;
            }

            if (!Validators.IsValidPassword(Password, out errorMessage))
            {
                PasswordErrorMessage = errorMessage;
                correctData = false;
            }

            return correctData;
        }
    }
}
