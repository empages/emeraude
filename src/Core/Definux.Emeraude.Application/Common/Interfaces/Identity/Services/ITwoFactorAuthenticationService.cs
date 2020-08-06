using Definux.Emeraude.Domain.Entities;
using System.Threading.Tasks;

namespace Definux.Emeraude.Application.Common.Interfaces.Identity.Services
{
    public interface ITwoFactorAuthenticationService
    {
        Task<string> GetFormattedKeyAsync(IUser user);

        Task<string> GenerateQrCodeUriAsync(IUser user);

        bool IsTwoFactorEnabled(IUser user);
    }
}
