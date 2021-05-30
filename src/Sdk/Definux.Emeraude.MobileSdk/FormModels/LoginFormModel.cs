using Definux.Emeraude.MobileSdk.FormModels.Abstractions;
using Definux.Emeraude.MobileSdk.Helpers;

namespace Definux.Emeraude.MobileSdk.FormModels
{
    /// <summary>
    /// Form model for login form.
    /// </summary>
    public class LoginFormModel : FormModel
    {
        private string email;
        private string password;

        /// <summary>
        /// Initializes a new instance of the <see cref="LoginFormModel"/> class.
        /// </summary>
        public LoginFormModel()
            : base()
        {
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

        /// <inheritdoc/>
        public override bool IsValid()
        {
            bool correctData = true;
            if (!Validators.IsValidEmail(this.Email, out string emailErrorMessage))
            {
                this.AddError(nameof(this.Email), emailErrorMessage);
                correctData = false;
            }

            return correctData;
        }
    }
}
