using System;
using System.Threading.Tasks;
using Definux.Emeraude.MobileSdk.Events;
using Definux.Emeraude.MobileSdk.ServiceAgents;
using Definux.Emeraude.MobileSdk.ServiceAgents.Models.Requests;

namespace Definux.Emeraude.MobileSdk.Stores
{
    /// <summary>
    /// Store that provides functionality for managing the authentication of the application.
    /// </summary>
    public interface IAuthenticationStore
    {
        /// <summary>
        /// Event which is triggered when a login try is completed (with or without a success).
        /// </summary>
        event EventHandler<LoginCompletedEventArgs> LoginCompleted;

        /// <summary>
        /// Flag that indicate whether the user is authenticated or not.
        /// </summary>
        bool IsAuthenticated { get; }

        /// <summary>
        /// Request access token via ordinary login request with email and password by accessing the <see cref="IAuthenticationServiceAgent"/>.
        /// </summary>
        /// <param name="loginRequest"></param>
        /// <returns></returns>
        Task RequestTokenAsync(LoginRequest loginRequest);

        /// <summary>
        /// Request access token via external provider token by accessing the <see cref="IAuthenticationServiceAgent"/>.
        /// </summary>
        /// <param name="externalLoginRequest"></param>
        /// <returns></returns>
        Task RequestTokenWithExternalProviderAsync(ExternalLoginRequest externalLoginRequest);
    }
}
