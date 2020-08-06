using Definux.Emeraude.MobileSdk.Configuration;
using Definux.Emeraude.MobileSdk.Constants;
using Definux.Emeraude.MobileSdk.Events;
using Definux.Emeraude.MobileSdk.ServiceAgents;
using Definux.Emeraude.MobileSdk.ServiceAgents.Models.Requests;
using Definux.Emeraude.MobileSdk.ServiceAgents.Models.Results;
using System;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace Definux.Emeraude.MobileSdk.Stores
{
    public class AuthenticationStore : Store, IAuthenticationStore
    {
        private readonly IAuthenticationServiceAgent authenticationServiceAgent;
        private readonly IEmConfiguration configuration;

        private BearerAuthenticationResult authenticationResult;

        public AuthenticationStore(
            IAuthenticationServiceAgent authenticationServiceAgent,
            ILoggingServiceAgent loggingServiceAgent,
            IEmConfiguration configuration)
            : base(loggingServiceAgent)
        {
            this.authenticationServiceAgent = authenticationServiceAgent;
            this.configuration = configuration;
        }

        public bool IsAuthenticated => this.authenticationResult != null && this.authenticationResult.Success;

        public async Task RequestTokenAsync(LoginRequest loginRequest)
        {
            if (!IsAuthenticated)
            {
                this.authenticationResult = await this.authenticationServiceAgent.RequestTokenAsync(loginRequest);
                await LoadUserTokensAsync();
            }
        }

        public async Task RequestTokenWithExternalProviderAsync(ExternalLoginRequest externalLoginRequest)
        {
            if (!IsAuthenticated)
            {
                this.authenticationResult = await this.authenticationServiceAgent.RequestTokenWithExternalProviderAsync(externalLoginRequest);
                await LoadUserTokensAsync();
            }
        }

        private async Task LoadUserTokensAsync()
        {
            if (IsAuthenticated)
            {
                await SecureStorage.SetAsync(Tokens.AccessTokenString, this.authenticationResult.JsonWebToken);
                await SecureStorage.SetAsync(Tokens.RefreshTokenString, this.authenticationResult.RefreshToken);
                LoginCompleted.Invoke(this, new LoginCompletedEventArgs(true));
            }
            else
            {
                LoginCompleted.Invoke(this, new LoginCompletedEventArgs(false));
            }
        }

        public event EventHandler<LoginCompletedEventArgs> LoginCompleted;
    }
}
