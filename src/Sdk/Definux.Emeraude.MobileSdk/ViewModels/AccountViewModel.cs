using System;
using Definux.Emeraude.MobileSdk.Configuration;
using Definux.Emeraude.MobileSdk.OAuth;
using Definux.Emeraude.MobileSdk.ServiceAgents.Models.Requests;
using Definux.Emeraude.MobileSdk.Services;
using Definux.Emeraude.MobileSdk.Stores;
using Newtonsoft.Json;
using Prism.Commands;
using Prism.Navigation;
using Xamarin.Auth;
using Xamarin.Auth.Presenters;

namespace Definux.Emeraude.MobileSdk.ViewModels
{
    /// <summary>
    /// An abstract ViewModel that defines the binding model for a page that contains access to login, register and external login actions.
    /// </summary>
    public abstract class AccountViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountViewModel"/> class.
        /// </summary>
        /// <param name="navigationService"></param>
        /// <param name="systemSettingsStore"></param>
        /// <param name="localizer"></param>
        /// <param name="authenticationStore"></param>
        /// <param name="configuration"></param>
        public AccountViewModel(
            INavigationService navigationService,
            ISystemSettingsStore systemSettingsStore,
            ILocalizer localizer,
            IAuthenticationStore authenticationStore,
            IEmConfiguration configuration)
            : base(navigationService, systemSettingsStore, localizer)
        {
            this.AuthenticationStore = authenticationStore;
            this.Configuration = configuration;

            this.GoToLoginPageCommand = new DelegateCommand(() => this.NavigationService.NavigateAsync("LoginPage"));
            this.GoToRegisterPageCommand = new DelegateCommand(() => this.NavigationService.NavigateAsync("RegisterPage"));
            this.LoginWithFacebookCommand = new DelegateCommand(() => this.LoginWithFacebook());
            this.LoginWithGoogleCommand = new DelegateCommand(() => this.LoginWithGoogle());
        }

        /// <inheritdoc cref="IEmConfiguration"/>
        public IEmConfiguration Configuration { get; private set; }

        /// <inheritdoc cref="IAuthenticationStore"/>
        public IAuthenticationStore AuthenticationStore { get; private set; }

        /// <inheritdoc cref="OAuthLoginPresenter"/>
        public OAuthLoginPresenter OAuthLoginPresenter { get; protected set; }

        /// <inheritdoc cref="OAuth2Authenticator"/>
        public OAuth2Authenticator OAuth2Authenticator { get; protected set; }

        /// <inheritdoc cref="OAuth2ProviderType"/>
        public OAuth2ProviderType OAuth2AuthenticatorType { get; set; }

        /// <summary>
        /// Command that redirect to login page.
        /// </summary>
        public DelegateCommand GoToLoginPageCommand { get; set; }

        /// <summary>
        /// Command that redirect to register page.
        /// </summary>
        public DelegateCommand GoToRegisterPageCommand { get; set; }

        /// <summary>
        /// Command that login with Facebook.
        /// </summary>
        public DelegateCommand LoginWithFacebookCommand { get; set; }

        /// <summary>
        /// Command that login with Google.
        /// </summary>
        public DelegateCommand LoginWithGoogleCommand { get; set; }

        private void LoginWithFacebook()
        {
            try
            {
                this.OAuth2AuthenticatorType = OAuth2ProviderType.Facebook;
                this.OAuth2Authenticator = OAuth2AuthenticatorHelper.CreateFacebookOAuth2Authenticator(this.Configuration);
                this.OAuth2Authenticator.Completed += this.OAuth2AuthenticatorCompleted;
                this.OAuth2Authenticator.Error += this.OAuth2AuthenticatorError;

                this.OAuthLoginPresenter = new OAuthLoginPresenter();
                this.OAuthLoginPresenter.Login(this.OAuth2Authenticator);
            }
            catch (Exception)
            {
            }
        }

        private void LoginWithGoogle()
        {
            try
            {
                this.OAuth2AuthenticatorType = OAuth2ProviderType.Google;
                this.OAuth2Authenticator = OAuth2AuthenticatorHelper.CreateGoogleOAuth2Authenticator(this.Configuration);
                this.OAuth2Authenticator.Completed += this.OAuth2AuthenticatorCompleted;
                this.OAuth2Authenticator.Error += this.OAuth2AuthenticatorError;

                this.OAuthLoginPresenter = new OAuthLoginPresenter();
                this.OAuthLoginPresenter.Login(this.OAuth2Authenticator);
            }
            catch (Exception)
            {
            }
        }

        private void OAuth2AuthenticatorCompleted(object sender, AuthenticatorCompletedEventArgs e)
        {
            try
            {
                if (e.IsAuthenticated)
                {
                    ExternalLoginRequest externalLoginRequest = new ExternalLoginRequest
                    {
                        Provider = this.OAuth2AuthenticatorType.ToString(),
                    };
                    var tokenResult = JsonConvert.DeserializeObject<OAuth2TokenResult>(JsonConvert.SerializeObject(e.Account.Properties));

                    externalLoginRequest.AccessToken = tokenResult.AccessToken;

                    this.AuthenticationStore.RequestTokenWithExternalProviderAsync(externalLoginRequest);
                }
            }
            catch (Exception)
            {
            }
            finally
            {
                this.OAuth2Authenticator.Completed -= this.OAuth2AuthenticatorCompleted;
                this.OAuth2Authenticator.Error -= this.OAuth2AuthenticatorError;
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
                this.OAuth2Authenticator.Completed -= this.OAuth2AuthenticatorCompleted;
                this.OAuth2Authenticator.Error -= this.OAuth2AuthenticatorError;
            }
        }
    }
}
