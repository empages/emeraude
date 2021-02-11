using System;
using MediatR;

namespace Definux.Emeraude.Admin.Requests
{
    /// <summary>
    /// Logger request abstraction class.
    /// </summary>
    /// <typeparam name="TResult">Result model.</typeparam>
    public abstract class LoggerRequest<TResult> : IRequest<TResult>
    {
        /// <summary>
        /// Pagination page index. First index is 1.
        /// </summary>
        public int Page { get; set; } = 1;

        /// <summary>
        /// Search query string.
        /// </summary>
        public string SearchQuery { get; set; }

        /// <summary>
        /// Filters by start date.
        /// </summary>
        public DateTime? FromDate { get; set; }

        /// <summary>
        /// Filters by end date.
        /// </summary>
        public DateTime? ToDate { get; set; }

        /// <summary>
        /// Filters by user.
        /// </summary>
        public string User { get; set; }
    }
}