using System;

namespace Definux.Emeraude.Admin.Requests.FetchLogs
{
    /// <summary>
    /// Fetch logs query contract.
    /// </summary>
    public interface IFetchLogsQuery
    {
        /// <summary>
        /// Pagination page index. First index is 1.
        /// </summary>
        int Page { get; set; }

        /// <summary>
        /// Search query string.
        /// </summary>
        string SearchQuery { get; set; }

        /// <summary>
        /// Filters by start date.
        /// </summary>
        DateTime? FromDate { get; set; }

        /// <summary>
        /// Filters by end date.
        /// </summary>
        DateTime? ToDate { get; set; }

        /// <summary>
        /// Filters by user.
        /// </summary>
        string User { get; set; }
    }
}