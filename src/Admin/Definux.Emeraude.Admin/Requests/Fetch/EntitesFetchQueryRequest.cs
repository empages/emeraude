using Microsoft.AspNetCore.Mvc;

namespace Definux.Emeraude.Admin.Requests.Fetch
{
    /// <summary>
    /// Fetch query context.
    /// </summary>
    public class EntitiesFetchQueryRequest
    {
        /// <summary>
        /// Pagination page index. First index is 1.
        /// </summary>
        [FromQuery]
        public int Page { get; set; } = 1;

        /// <summary>
        /// Search query string.
        /// </summary>
        [FromQuery]
        public string SearchQuery { get; set; }

        /// <summary>
        /// Order property.
        /// </summary>
        [FromQuery]
        public string OrderBy { get; set; }

        /// <summary>
        /// Order type.
        /// </summary>
        [FromQuery]
        public string OrderType { get; set; }
    }
}