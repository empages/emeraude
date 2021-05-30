using Definux.Emeraude.Admin.ClientBuilder.Models;

namespace Definux.Emeraude.Admin.ClientBuilder.Shared.Helpers
{
    /// <summary>
    /// Helper class that contains route and client builder page model.
    /// </summary>
    internal class ClientRoutePagePair
    {
        /// <summary>
        /// Route implementation.
        /// </summary>
        internal ClientRoute Route { get; set; }

        /// <summary>
        /// Route page.
        /// </summary>
        internal Page Page { get; set; }
    }
}
