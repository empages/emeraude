using System;
using System.Threading.Tasks;

namespace Definux.Emeraude.Admin.UI.Adapters
{
    /// <summary>
    /// Adapted for transferring data to Admin UI assembly.
    /// </summary>
    public interface IIdentityUserInfoAdapter
    {
        /// <summary>
        /// Get current user info.
        /// </summary>
        /// <returns></returns>
        Task<UserInfoResult?> GetCurrentUserInfoAsync();
    }

    /// <summary>
    /// Simplified user info result.
    /// </summary>
    public struct UserInfoResult
    {
        /// <summary>
        /// Id of the user.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Name of the user.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Email of the user.
        /// </summary>
        public string Email { get; set; }
    }
}
