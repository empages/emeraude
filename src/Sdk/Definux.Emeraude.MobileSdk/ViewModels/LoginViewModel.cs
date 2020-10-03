using System.Threading.Tasks;
using Definux.Emeraude.MobileSdk.FormModels;
using Definux.Emeraude.MobileSdk.ServiceAgents.Models.Requests;
using Definux.Emeraude.MobileSdk.Services;
using Definux.Emeraude.MobileSdk.Stores;
using Prism.Commands;
using Prism.Navigation;

namespace Definux.Emeraude.MobileSdk.ViewModels
{
    /// <summary>
    /// An abstract ViewModel that defines the binding model for a page that contains login form.
    /// </summary>
    public abstract class LoginViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoginViewModel"/> class.
        /// </summary>
        /// <param name="navigationService"></param>
        /// <param name="systemSettingsStore"></param>
        /// <param name="authenticationStore"></param>
        /// <param name="localizer"></param>
        public LoginViewModel(
            INavigationService navigationService,
            ISystemSettingsStore systemSettingsStore,
            IAuthenticationStore authenticationStore,
            ILocalizer localizer)
            : base(navigationService, systemSettingsStore, localizer)
        {
            this.AuthenticationStore = authenticationStore;
            this.GoToForgotPasswordPageCommand = new DelegateCommand(() => this.NavigationService.NavigateAsync("ForgotPasswordPage"));
            this.GoToRegisterPageCommand = new DelegateCommand(() => this.NavigationService.NavigateAsync("RegisterPage"));
            this.SubmitLoginCommand = new DelegateCommand(async () => await this.SubmitLoginAsync());
            this.LoginModel = new LoginFormModel();
        }

        /// <inheritdoc cref="IAuthenticationStore"/>
        public IAuthenticationStore AuthenticationStore { get; private set; }

        /// <summary>
        /// Command that redirect to forgot password page.
        /// </summary>
        public DelegateCommand GoToForgotPasswordPageCommand { get; set; }

        /// <summary>
        /// Command that redirect to register page.
        /// </summary>
        public DelegateCommand GoToRegisterPageCommand { get; set; }

        /// <summary>
        /// Command that submit the login form.
        /// </summary>
        public DelegateCommand SubmitLoginCommand { get; set; }

        /// <summary>
        /// Binding model for the login form.
        /// </summary>
        public LoginFormModel LoginModel { get; set; }

        private async Task SubmitLoginAsync()
        {
            if (this.LoginModel.IsValid())
            {
                await this.AuthenticationStore.RequestTokenAsync(new LoginRequest
                {
                    Email = this.LoginModel.Email,
                    Password = this.LoginModel.Password,
                });
            }
        }
    }
}
