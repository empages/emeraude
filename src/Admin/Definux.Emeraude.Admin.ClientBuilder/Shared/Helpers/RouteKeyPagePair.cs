using Definux.Emeraude.Admin.ClientBuilder.Models;

namespace Definux.Emeraude.Admin.ClientBuilder.Shared.Helpers
{
    /// <summary>
    /// Helper class that contains route key and client builder page model.
    /// </summary>
    internal class RouteKeyPagePair
    {
        /// <summary>
        /// Route key.
        /// </summary>
        internal string Key { get; set; }

        /// <summary>
        /// Route page.
        /// </summary>
        internal Page Page { get; set; }
    }
}
