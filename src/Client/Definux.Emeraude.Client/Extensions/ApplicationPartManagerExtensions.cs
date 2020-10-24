using Definux.Emeraude.Client.UI;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Definux.Emeraude.Client.Extensions
{
    /// <summary>
    /// Extensions for <see cref="ApplicationPartManager"/>.
    /// </summary>
    public static class ApplicationPartManagerExtensions
    {
        /// <summary>
        /// Add Client UI application parts.
        /// </summary>
        /// <param name="applicationPartManager"></param>
        /// <returns></returns>
        public static ApplicationPartManager AddClientUIApplicationParts(this ApplicationPartManager applicationPartManager)
        {
            applicationPartManager.ApplicationParts.Add(ClientUIAssemblyPart.AssemblyPart);

            return applicationPartManager;
        }
    }
}
