using System;
using System.Threading.Tasks;

namespace Definux.Emeraude.Admin.UI.Adapters
{
    public interface IIdentityUserInfoAdapter
    {
        Task<UserInfoResult?> GetCurrentUserInfoAsync();
    }

    public struct UserInfoResult
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }
    }
}
