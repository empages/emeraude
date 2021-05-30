using System;
using System.Threading.Tasks;
using Definux.Emeraude.MobileSdk.Configuration;
using Definux.Emeraude.MobileSdk.Constants;
using Definux.Emeraude.MobileSdk.Events;
using Definux.Emeraude.MobileSdk.ServiceAgents;
using Definux.Emeraude.MobileSdk.ServiceAgents.Models.Requests;
using Definux.Emeraude.MobileSdk.ServiceAgents.Models.Results;
using Xamarin.Essentials;

namespace Definux.Emeraude.MobileSdk.Stores
{
    /// <inheritdoc cref="IAuthenticationStore"/>
    public class AuthenticationStore : Store, IAuthenticationStore
    {
        private readonly IAuthenticationServiceAgent authenticationServiceAgent;
        private readonly IEmConfiguration configuration;

        private BearerAuthenticationResult authenticationResult;

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationStore"/> class.
        /// </summary>
        /// <param name="authenticationServiceAgent"></param>
        /// <param name="loggingServiceAgent"></param>
        /// <param name="configuration"></param>
        public AuthenticationStore(
            IAuthenticationServiceAgent authenticationServiceAgent,
            ILoggingServiceAgent loggingServiceAgent,
            IEmConfiguration configuration)
            : base(loggingServiceAgent)
        {
            this.authenticationServiceAgent = authenticationServiceAgent;
            this.configuration = configuration;
        }

        /// <inheritdoc/>
        public event EventHandler<LoginCompletedEventArgs> LoginCompleted;

        /// <inheritdoc/>
        public bool IsAuthenticated => this.authenticationResult != null && this.authenticationResult.Success;

        /// <inheritdoc/>
        public async Task RequestTokenAsync(LoginRequest loginRequest)
        {
            if (!this.IsAuthenticated)
            {
                this.authenticationResult = await this.authenticationServiceAgent.RequestTokenAsync(loginRequest);
                await this.LoadUserTokensAsync();
            }
        }

        /// <inheritdoc/>
        public async Task RequestTokenWithExternalProviderAsync(ExternalLoginRequest externalLoginRequest)
        {
            if (!this.IsAuthenticated)
            {
                this.authenticationResult = await this.authenticationServiceAgent.RequestTokenWithExternalProviderAsync(externalLoginRequest);
                await this.LoadUserTokensAsync();
            }
        }

        private async Task LoadUserTokensAsync()
        {
            if (this.IsAuthenticated)
            {
                await SecureStorage.SetAsync(Tokens.AccessTokenString, this.authenticationResult.JsonWebToken);
                await SecureStorage.SetAsync(Tokens.RefreshTokenString, this.authenticationResult.RefreshToken);
                this.LoginCompleted.Invoke(this, new LoginCompletedEventArgs(true));
            }
            else
            {
                this.LoginCompleted.Invoke(this, new LoginCompletedEventArgs(false));
            }
        }
    }
}
