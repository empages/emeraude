using System.Threading.Tasks;
using Definux.Emeraude.Domain.Entities;

namespace Definux.Emeraude.Application.Common.Interfaces.Identity.Services
{
    /// <summary>
    /// Two factor authentication service that provides specific methods for managing this functionality into the system.
    /// </summary>
    public interface ITwoFactorAuthenticationService
    {
        /// <summary>
        /// Get formatted authentication key for specific user.
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        Task<string> GetFormattedKeyAsync(IUser user);

        /// <summary>
        /// Generate QR code URL for specific user.
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        Task<string> GenerateQrCodeUriAsync(IUser user);

        /// <summary>
        /// Check whether a user is enabled two factor authentication.
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        bool IsTwoFactorEnabled(IUser user);
    }
}