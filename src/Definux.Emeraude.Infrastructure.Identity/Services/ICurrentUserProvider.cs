using System;
using System.Threading.Tasks;
using Definux.Emeraude.Contracts;

namespace Definux.Emeraude.Infrastructure.Identity.Services
{
    /// <summary>
    /// Helper accessor service that provides the identity user for the current request.
    /// </summary>
    public interface ICurrentUserProvider
    {
        /// <summary>
        /// Current user id.
        /// </summary>
        Guid? CurrentUserId { get; }

        /// <summary>
        /// Returns current request user.
        /// </summary>
        /// <returns></returns>
        Task<IUser> GetCurrentUserAsync();
    }
}
