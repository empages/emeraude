using System.Threading.Tasks;
using Definux.Emeraude.MobileSdk.FormModels;
using Definux.Emeraude.MobileSdk.Services;
using Definux.Emeraude.MobileSdk.Stores;
using Prism.Commands;
using Prism.Navigation;

namespace Definux.Emeraude.MobileSdk.ViewModels
{
    /// <summary>
    /// An abstract ViewModel that defines the binding model for a page that contains register form.
    /// </summary>
    public abstract class RegisterViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterViewModel"/> class.
        /// </summary>
        /// <param name="navigationService"></param>
        /// <param name="systemSettingsStore"></param>
        /// <param name="authenticationStore"></param>
        /// <param name="localizer"></param>
        public RegisterViewModel(
            INavigationService navigationService,
            ISystemSettingsStore systemSettingsStore,
            IAuthenticationStore authenticationStore,
            ILocalizer localizer)
            : base(navigationService, systemSettingsStore, localizer)
        {
            this.AuthenticationStore = authenticationStore;
            this.GoToLoginPageCommand = new DelegateCommand(() => this.NavigationService.NavigateAsync("LoginPage"));
            this.SubmitRegistrationCommand = new DelegateCommand(async () => await this.SubmitRegistrationAsync());
        }

        /// <inheritdoc cref="IAuthenticationStore"/>
        public IAuthenticationStore AuthenticationStore { get; private set; }

        /// <summary>
        /// Command that redirect to login page.
        /// </summary>
        public DelegateCommand GoToLoginPageCommand { get; set; }

        /// <summary>
        /// Command that submit the register form.
        /// </summary>
        public DelegateCommand SubmitRegistrationCommand { get; set; }

        /// <summary>
        /// Binding model for the register form.
        /// </summary>
        public RegisterFormModel RegisterModel { get; set; }

        private async Task SubmitRegistrationAsync()
        {
            if (this.RegisterModel.IsValid())
            {
            }
        }
    }
}
