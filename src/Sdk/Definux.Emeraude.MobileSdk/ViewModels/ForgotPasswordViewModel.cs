using Definux.Emeraude.MobileSdk.Services;
using Definux.Emeraude.MobileSdk.Stores;
using Prism.Commands;
using Prism.Navigation;
using System.Resources;
using System.Threading.Tasks;

namespace Definux.Emeraude.MobileSdk.ViewModels
{
    public class ForgotPasswordViewModel : ViewModelBase
    {
        private string email;

        public ForgotPasswordViewModel(
            INavigationService navigationService,
            ISystemSettingsStore systemSettingsStore,
            IAuthenticationStore authenticationStore,
            ILocalizer localizer)
            : base(navigationService, systemSettingsStore, localizer)
        {
            AuthenticationStore = authenticationStore;

            SubmitResetPasswordCommand = new DelegateCommand(async () => await SubmitResetPasswordAsync());
        }

        public IAuthenticationStore AuthenticationStore { get; private set; }

        public DelegateCommand SubmitResetPasswordCommand { get; set; }

        #region FormProperties

        public string Email
        {
            get => this.email;
            set => SetProperty(ref this.email, value);
        }

        #endregion

        private async Task SubmitResetPasswordAsync()
        {

        }
    }
}
