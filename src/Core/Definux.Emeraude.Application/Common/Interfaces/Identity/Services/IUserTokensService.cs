using Definux.Emeraude.Application.Common.Results.Identity;
using Definux.Emeraude.Application.Requests.Identity.Commands.ExternalAuthentication;
using System;
using System.Threading.Tasks;

namespace Definux.Emeraude.Application.Common.Interfaces.Identity.Services
{
    public interface IUserTokensService
    {
        Task<BearerAuthenticationResult> BuildJwtTokenForUserAsync(Guid userId);

        Task<BearerAuthenticationResult> BuildJwtTokenForExternalUserAsync(IExternalUser externalUser);

        Task<BearerAuthenticationResult> RefreshJwtTokenAsync(Guid? userId, string refreshToken);

        Task<bool> ResetRefreshTokenAsync(Guid userId);
    }
}
