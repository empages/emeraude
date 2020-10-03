using Definux.Emeraude.MobileSdk.FormModels.Abstractions;
using Definux.Emeraude.MobileSdk.Helpers;

namespace Definux.Emeraude.MobileSdk.FormModels
{
    /// <summary>
    /// Form model for register form.
    /// </summary>
    public class RegisterFormModel : FormModel
    {
        private string fullName;
        private string email;
        private string password;
        private string confirmedPassword;

        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterFormModel"/> class.
        /// </summary>
        public RegisterFormModel()
            : base()
        {
        }

        /// <summary>
        /// Full name of the user.
        /// </summary>
        public string FullName
        {
            get => this.fullName;
            set => this.SetProperty(ref this.fullName, value);
        }

        /// <summary>
        /// Email of the user.
        /// </summary>
        public string Email
        {
            get => this.email;
            set => this.SetProperty(ref this.email, value);
        }

        /// <summary>
        /// User password.
        /// </summary>
        public string Password
        {
            get => this.password;
            set => this.SetProperty(ref this.password, value);
        }

        /// <summary>
        /// Confirmed user password.
        /// </summary>
        public string ConfirmedPassword
        {
            get => this.confirmedPassword;
            set => this.SetProperty(ref this.confirmedPassword, value);
        }

        /// <inheritdoc/>
        public override bool IsValid()
        {
            bool correctData = true;
            if (!Validators.IsValidEmail(this.Email, out string emailErrorMessage))
            {
                this.AddError(nameof(this.Email), emailErrorMessage);
                correctData = false;
            }

            if (!Validators.IsValidPassword(this.Password, out string passwordErrorMessage))
            {
                this.AddError(nameof(this.Password), passwordErrorMessage);
                correctData = false;
            }

            return correctData;
        }
    }
}
