using System;
using System.Threading.Tasks;
using Definux.Emeraude.Domain.Entities;

namespace Definux.Emeraude.Application.Common.Interfaces.Identity.Services
{
    /// <summary>
    /// Service specified for user avatar processing.
    /// </summary>
    public interface IUserAvatarService
    {
        /// <summary>
        /// Apply local saved avatar to specified user.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="avatarUrl"></param>
        /// <returns></returns>
        Task ApplyAvatarToUserAsync(Guid userId, string avatarUrl);

        /// <summary>
        /// Create avatar for a user from external file source.
        /// </summary>
        /// <param name="externalSourceAvatarUrl"></param>
        /// <returns></returns>
        Task<string> CreateAvatarFromUrlAsync(string externalSourceAvatarUrl);

        /// <summary>
        /// Create avatar for a user from file in byte array format.
        /// </summary>
        /// <param name="avatarFileByteArray"></param>
        /// <returns></returns>
        Task<string> CreateUserAvatarAsync(byte[] avatarFileByteArray);

        /// <summary>
        /// Get user avatar relative path.
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        string GetUserAvatarRelativePath(IUser user);
    }
}
