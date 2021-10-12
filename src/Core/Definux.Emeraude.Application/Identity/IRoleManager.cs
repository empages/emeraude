using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Definux.Emeraude.Domain.Entities;

namespace Definux.Emeraude.Application.Identity
{
    /// <summary>
    /// Emeraude role manager service.
    /// </summary>
    public interface IRoleManager
    {
        /// <summary>
        /// Create role entity by name and claims.
        /// </summary>
        /// <param name="roleName"></param>
        /// <param name="claims"></param>
        /// <returns></returns>
        Task<bool> CreateRoleAsync(string roleName, IEnumerable<string> claims);

        /// <summary>
        /// Delete role entity.
        /// </summary>
        /// <param name="roleName"></param>
        /// <returns></returns>
        Task<bool> DeleteRoleAsync(string roleName);

        /// <summary>
        /// Get all roles as a dictionary.
        /// </summary>
        /// <returns></returns>
        Task<Dictionary<Guid, string>> GetRolesAsync();

        /// <summary>
        /// Get all roles for a user as a dictionary.
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        Task<Dictionary<Guid, string>> GetUserRolesAsync(IUser user);

        /// <summary>
        /// Removes all roles from a user.
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        Task<bool> RemoveAllRolesFromUserAsync(IUser user);

        /// <summary>
        /// Assign specified roles to a user.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="roleIds"></param>
        /// <returns></returns>
        Task<bool> AssignRolesToUserAsync(IUser user, IEnumerable<Guid> roleIds);
    }
}
