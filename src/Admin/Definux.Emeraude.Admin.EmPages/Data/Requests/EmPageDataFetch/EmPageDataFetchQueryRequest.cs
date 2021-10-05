using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Primitives;
using static System.Int32;

namespace Definux.Emeraude.Admin.EmPages.Data.Requests.EmPageDataFetch
{
    /// <summary>
    /// Fetch query context.
    /// </summary>
    public class EmPageDataFetchQueryRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmPageDataFetchQueryRequest"/> class.
        /// </summary>
        /// <param name="query"></param>
        public EmPageDataFetchQueryRequest(IDictionary<string, StringValues> query)
        {
            this.LoadParameters(query);
        }

        /// <summary>
        /// Pagination page index. First index is 1.
        /// </summary>
        public int Page { get; set; } = 1;

        /// <summary>
        /// Search query string.
        /// </summary>
        public string SearchQuery { get; set; }

        /// <summary>
        /// Order property.
        /// </summary>
        public string OrderBy { get; set; }

        /// <summary>
        /// Order type.
        /// </summary>
        public string OrderType { get; set; }

        private void LoadParameters(IDictionary<string, StringValues> query)
        {
            if (query == null)
            {
                return;
            }

            var normalizedQuery = query.ToDictionary(k => k.Key.ToLowerInvariant(), v => v.Value);

            var pageKey = nameof(this.Page).ToLowerInvariant();
            if (normalizedQuery.ContainsKey(pageKey))
            {
                var pageRawValue = normalizedQuery[pageKey].FirstOrDefault();
                if (int.TryParse(pageRawValue, out var page))
                {
                    this.Page = page > 0 ? page : 1;
                }
            }

            var searchQueryKey = nameof(this.SearchQuery).ToLowerInvariant();
            if (normalizedQuery.ContainsKey(searchQueryKey))
            {
                this.SearchQuery = normalizedQuery[searchQueryKey].FirstOrDefault();
            }

            var orderByKey = nameof(this.OrderBy).ToLowerInvariant();
            if (normalizedQuery.ContainsKey(orderByKey))
            {
                this.OrderBy = normalizedQuery[orderByKey].FirstOrDefault();
            }

            var orderTypeKey = nameof(this.OrderType).ToLowerInvariant();
            if (normalizedQuery.ContainsKey(orderTypeKey))
            {
                this.OrderType = normalizedQuery[orderTypeKey].FirstOrDefault();
            }
        }
    }
}