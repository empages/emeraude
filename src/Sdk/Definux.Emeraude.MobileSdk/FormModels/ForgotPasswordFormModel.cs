using Definux.Emeraude.MobileSdk.FormModels.Abstractions;
using Definux.Emeraude.MobileSdk.Helpers;

namespace Definux.Emeraude.MobileSdk.FormModels
{
    /// <summary>
    /// Form model for forgot password form.
    /// </summary>
    public class ForgotPasswordFormModel : FormModel
    {
        private string email;

        /// <summary>
        /// Initializes a new instance of the <see cref="ForgotPasswordFormModel"/> class.
        /// </summary>
        public ForgotPasswordFormModel()
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
