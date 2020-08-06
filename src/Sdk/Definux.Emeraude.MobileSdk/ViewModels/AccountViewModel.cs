using Definux.Emeraude.MobileSdk.Configuration;
using Definux.Emeraude.MobileSdk.OAuth;
using Definux.Emeraude.MobileSdk.Stores;
using Definux.Emeraude.MobileSdk.ServiceAgents.Models.Requests;
using Newtonsoft.Json;
using Prism.Commands;
using Prism.Navigation;
using System;
using System.Resources;
using Xamarin.Auth;
using Xamarin.Auth.Presenters;
using Definux.Emeraude.MobileSdk.Services;

namespace Definux.Emeraude.MobileSdk.ViewModels
{
    public class AccountViewModel : ViewModelBase
    {
        public AccountViewModel(
            INavigationService navigationService,
            ISystemSettingsStore systemSettingsStore,
            ILocalizer localizer,
            IAuthenticationStore authenticationStore,
            IEmConfiguration configuration)
            : base(navigationService, systemSettingsStore, localizer)
        {
            AuthenticationStore = authenticationStore;
            Configuration = configuration;

            GoToLoginPageCommand = new DelegateCommand(() => NavigationService.NavigateAsync("LoginPage"));
            GoToRegisterPageCommand = new DelegateCommand(() => NavigationService.NavigateAsync("RegisterPage"));
            LoginWithFacebookCommand = new DelegateCommand(() => LoginWithFacebook());
            LoginWithGoogleCommand = new DelegateCommand(() => LoginWithGoogle());
        }

        public IEmConfiguration Configuration { get; private set; }

        public IAuthenticationStore AuthenticationStore { get; private set; }

        public OAuthLoginPresenter OAuthLoginPresenter { get; protected set; }

        public OAuth2Authenticator OAuth2Authenticator { get; protected set; }

        public OAuth2ProviderType OAuth2AuthenticatorType { get; set; }

        public DelegateCommand GoToLoginPageCommand { get; set; }

        public DelegateCommand GoToRegisterPageCommand { get; set; }

        public DelegateCommand LoginWithFacebookCommand { get; set; }

        public DelegateCommand LoginWithGoogleCommand { get; set; }

        private void LoginWithFacebook()
        {
            try
            {
                OAuth2AuthenticatorType = OAuth2ProviderType.Facebook;
                OAuth2Authenticator = OAuth2AuthenticatorHelper.CreateFacebookOAuth2Authenticator(Configuration);
                OAuth2Authenticator.Completed += OAuth2AuthenticatorCompleted;
                OAuth2Authenticator.Error += OAuth2AuthenticatorError;

                OAuthLoginPresenter = new OAuthLoginPresenter();
                OAuthLoginPresenter.Login(OAuth2Authenticator);
            }
            catch (Exception ex)
            {
            }
        }

        private void LoginWithGoogle()
        {
            try
            {
                OAuth2AuthenticatorType = OAuth2ProviderType.Google;
                OAuth2Authenticator = OAuth2AuthenticatorHelper.CreateGoogleOAuth2Authenticator(Configuration);
                OAuth2Authenticator.Completed += OAuth2AuthenticatorCompleted;
                OAuth2Authenticator.Error += OAuth2AuthenticatorError;

                OAuthLoginPresenter = new OAuthLoginPresenter();
                OAuthLoginPresenter.Login(OAuth2Authenticator);
            }
            catch (Exception ex)
            {
            }
        }

        private void OAuth2AuthenticatorCompleted(object sender, AuthenticatorCompletedEventArgs e)
        {
            try
            {
                if (e.IsAuthenticated)
                {
                    ExternalLoginRequest externalLoginRequest = new ExternalLoginRequest { Provider = OAuth2AuthenticatorType.ToString() }; 
                    var tokenResult = JsonConvert.DeserializeObject<OAuth2TokenResult>(JsonConvert.SerializeObject(e.Account.Properties));

                    externalLoginRequest.AccessToken = tokenResult.AccessToken;

                    AuthenticationStore.RequestTokenWithExternalProviderAsync(externalLoginRequest);
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                OAuth2Authenticator.Completed -= OAuth2AuthenticatorCompleted;
                OAuth2Authenticator.Error -= OAuth2AuthenticatorError;
            }
        }

        private void OAuth2AuthenticatorError(object sender, AuthenticatorErrorEventArgs e)
        {
            try
            {

            }
            catch (Exception)
            {

            }
            finally
            {
                OAuth2Authenticator.Completed -= OAuth2AuthenticatorCompleted;
                OAuth2Authenticator.Error -= OAuth2AuthenticatorError;
            }
        }
    }

}
