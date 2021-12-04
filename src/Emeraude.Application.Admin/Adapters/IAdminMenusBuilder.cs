using System.Threading.Tasks;
using Emeraude.Application.Admin.Models;

namespace Emeraude.Application.Admin.Adapters;

/// <summary>
/// Contract for setup admin menus via <see cref="SidebarSchema"/>.
/// </summary>
public interface IAdminMenusBuilder
{
    /// <summary>
    /// Setup method for building the admin menus.
    /// </summary>
    /// <returns></returns>
    Task<SidebarSchema> BuildAsync();
}