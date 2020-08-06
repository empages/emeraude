using Definux.Emeraude.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace Definux.Emeraude.Application.Common.Interfaces.Identity.Services
{
    public interface IUserAvatarService
    {
        Task ApplyAvatarToUserAsync(Guid userId, string avatarUrl);

        Task<string> CreateAvatarFromUrlAsync(string externalSourceAvatarUrl);

        Task<string> CreateUserAvatarAsync(byte[] avatarFileByteArray);

        string GetUserAvatarRelativePath(IUser user);
    }
}
