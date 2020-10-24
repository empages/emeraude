using System.Threading.Tasks;
using Definux.Emeraude.Interfaces.Services;
using Definux.Emeraude.MobileSdk.FormModels;
using Definux.Emeraude.MobileSdk.Services;
using Definux.Emeraude.MobileSdk.Stores;
using Prism.Commands;
using Prism.Navigation;

namespace Definux.Emeraude.MobileSdk.ViewModels
{
    /// <summary>
    /// An abstract ViewModel that defines the binding model for a page that contains forgot password form.
    /// </summary>
    public abstract class ForgotPasswordViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ForgotPasswordViewModel"/> class.
        /// </summary>
        /// <param name="navigationService"></param>
        /// <param name="systemSettingsStore"></param>
        /// <param name="authenticationStore"></param>
        /// <param name="localizer"></param>
        public ForgotPasswordViewModel(
            INavigationService navigationService,
            ISystemSettingsStore systemSettingsStore,
            IAuthenticationStore authenticationStore,
            ILocalizer localizer)
            : base(navigationService, systemSettingsStore, localizer)
        {
            this.AuthenticationStore = authenticationStore;
            this.SubmitForgotPasswordFormCommand = new DelegateCommand(async () => await this.SubmitForgotPasswordFormAsync());
        }

        /// <inheritdoc cref="IAuthenticationStore"/>
        public IAuthenticationStore AuthenticationStore { get; private set; }

        /// <summary>
        /// Command that submit the forgot password form.
        /// </summary>
        public DelegateCommand SubmitForgotPasswordFormCommand { get; set; }

        /// <summary>
        /// Binding model for the forgot password form.
        /// </summary>
        public ForgotPasswordFormModel ForgotPasswordModel { get; set; }

        private async Task SubmitForgotPasswordFormAsync()
        {
            if (this.ForgotPasswordModel.IsValid())
            {
            }
        }
    }
}
