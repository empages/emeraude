using Definux.Emeraude.MobileSdk.Services;
using Definux.Emeraude.MobileSdk.Stores;
using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace Definux.Emeraude.MobileSdk.ViewModels
{
    public class RegisterViewModel : ViewModelBase
    {
        private string fullName;
        private string email;
        private string password;
        private string confirmedPassword;

        public RegisterViewModel(
            INavigationService navigationService,
            ISystemSettingsStore systemSettingsStore,
            IAuthenticationStore authenticationStore,
            ILocalizer localizer)
            : base(navigationService, systemSettingsStore, localizer)
        {
            AuthenticationStore = authenticationStore;

            GoToLoginPageCommand = new DelegateCommand(() => NavigationService.NavigateAsync("LoginPage"));
            SubmitRegistrationCommand = new DelegateCommand(async () => await SubmitRegistrationAsync());
        }

        public IAuthenticationStore AuthenticationStore { get; private set; }

        public DelegateCommand GoToLoginPageCommand { get; set; }
        public DelegateCommand SubmitRegistrationCommand { get; set; }

        #region FormProperties

        public string FullName
        {
            get => this.fullName;
            set => SetProperty(ref this.fullName, value);
        }

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

        public string ConfirmedPassword
        {
            get => this.confirmedPassword;
            set => SetProperty(ref this.confirmedPassword, value);
        }

        #endregion

        private async Task SubmitRegistrationAsync()
        {

        }

        private bool ValidateEnteredData()
        {
            return false;
        }
    }
}
