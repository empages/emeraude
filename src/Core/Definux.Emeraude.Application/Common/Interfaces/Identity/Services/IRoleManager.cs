using Definux.Emeraude.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Definux.Emeraude.Application.Common.Interfaces.Identity.Services
{
    public interface IRoleManager
    {
        Task<bool> CreateRoleAsync(string roleName, IEnumerable<string> claims);

        Task<bool> DeleteRoleAsync(string roleName);

        Task<Dictionary<Guid, string>> GetRolesAsync();

        Task<Dictionary<Guid, string>> GetUserRolesAsync(IUser user);

        Task<bool> UnassignAllRolesFromUserAsync(IUser user);

        Task<bool> AssignRolesToUserAsync(IUser user, IEnumerable<Guid> roleIds);
    }
}
