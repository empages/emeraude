using Definux.Emeraude.ClientBuilder.Models;

namespace Definux.Emeraude.ClientBuilder.Shared.Helpers
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
