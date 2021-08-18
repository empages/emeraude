using System;
using Definux.Emeraude.Application.Models;
using MediatR;

namespace Definux.Emeraude.Admin.Requests.FetchLogs
{
    /// <summary>
    /// Logger query abstraction class.
    /// </summary>
    /// <typeparam name="TResult">Result of the query.</typeparam>
    public abstract class FetchLogsQuery<TResult> : IRequest<TResult>, IFetchLogsQuery
    {
        /// <inheritdoc />
        public int Page { get; set; } = 1;

        /// <inheritdoc />
        public string SearchQuery { get; set; }

        /// <inheritdoc />
        public DateModel? FromDate { get; set; }

        /// <inheritdoc />
        public DateModel? ToDate { get; set; }

        /// <inheritdoc />
        public string User { get; set; }
    }
}