using Definux.Emeraude.Interfaces.Requests;
using Definux.Emeraude.MobileSdk.Events;
using Definux.Emeraude.MobileSdk.ServiceAgents.Models.Requests;
using System;
using System.Threading.Tasks;

namespace Definux.Emeraude.MobileSdk.Stores
{
    public interface IAuthenticationStore
    {
        bool IsAuthenticated { get; }      

        Task RequestTokenAsync(LoginRequest loginRequest);

        Task RequestTokenWithExternalProviderAsync(ExternalLoginRequest externalLoginRequest);

        event EventHandler<LoginCompletedEventArgs> LoginCompleted;
    }
}
