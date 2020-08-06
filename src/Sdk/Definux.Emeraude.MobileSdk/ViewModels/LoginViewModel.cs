using Definux.Emeraude.MobileSdk.FormModels;
using Definux.Emeraude.MobileSdk.Stores;
using Definux.Emeraude.MobileSdk.ServiceAgents.Models.Requests;
using Prism.Commands;
using Prism.Navigation;
using System.Resources;
using System.Threading.Tasks;
using Definux.Emeraude.MobileSdk.Services;

namespace Definux.Emeraude.MobileSdk.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {

        public LoginViewModel(
            INavigationService navigationService,
            ISystemSettingsStore systemSettingsStore,
            IAuthenticationStore authenticationStore,
            ILocalizer localizer)
            : base(navigationService, systemSettingsStore, localizer)
        {
            AuthenticationStore = authenticationStore;

            GoToForgotPasswordPageCommand = new DelegateCommand(() => NavigationService.NavigateAsync("ForgotPasswordPage"));
            GoToRegisterPageCommand = new DelegateCommand(() => NavigationService.NavigateAsync("RegisterPage"));
            SubmitLoginCommand = new DelegateCommand(async () => await SubmitLoginAsync());

            LoginModel = new LoginFormModel();
        }

        public IAuthenticationStore AuthenticationStore { get; private set; }

        public DelegateCommand GoToForgotPasswordPageCommand { get; set; }

        public DelegateCommand GoToRegisterPageCommand { get; set; }

        public DelegateCommand SubmitLoginCommand { get; set; }

        public LoginFormModel LoginModel { get; set; }

        private async Task SubmitLoginAsync()
        {
            if (LoginModel.IsValid())
            {
                await AuthenticationStore.RequestTokenAsync(new LoginRequest
                {
                    Email = LoginModel.Email,
                    Password = LoginModel.Password
                });
            }
        }
    }
}
