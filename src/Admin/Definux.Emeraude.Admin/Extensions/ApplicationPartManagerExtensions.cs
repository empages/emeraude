using Definux.Emeraude.Admin.UI;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Definux.Emeraude.Admin.Extensions
{
    /// <summary>
    /// Extensions for <see cref="ApplicationPartManager"/>.
    /// </summary>
    public static class ApplicationPartManagerExtensions
    {
        /// <summary>
        /// Add Admin UI application parts.
        /// </summary>
        /// <param name="applicationPartManager"></param>
        /// <returns></returns>
        public static ApplicationPartManager AddAdminUIApplicationParts(this ApplicationPartManager applicationPartManager)
        {
            applicationPartManager.ApplicationParts.Add(AdminUIAssemblyPart.AssemblyPart);

            return applicationPartManager;
        }
    }
}