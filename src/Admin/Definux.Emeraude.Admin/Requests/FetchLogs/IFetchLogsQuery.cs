using System;
using Definux.Emeraude.Application.Models;

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
        DateModel? FromDate { get; set; }

        /// <summary>
        /// Filters by end date.
        /// </summary>
        DateModel? ToDate { get; set; }

        /// <summary>
        /// Filters by user.
        /// </summary>
        string User { get; set; }
    }
}