using System.Collections.Generic;
using System.Threading.Tasks;
using Definux.Emeraude.Admin.UI.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Definux.Emeraude.Admin.UI.Adapters
{
    /// <summary>
    /// Contract for setup admin menus via <see cref="AdminNavigationSchema"/>.
    /// </summary>
    public interface IAdminMenusBuilder
    {
        /// <summary>
        /// Setup method for building the admin menus.
        /// </summary>
        /// <returns></returns>
        Task<AdminNavigationSchema> BuildAsync();
    }
}