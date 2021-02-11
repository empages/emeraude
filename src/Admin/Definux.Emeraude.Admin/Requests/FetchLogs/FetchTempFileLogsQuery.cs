using System;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Definux.Emeraude.Admin.UI.ViewModels.Logging;
using Definux.Emeraude.Application.Logger;
using Definux.Emeraude.Application.Persistence;
using Definux.Emeraude.Domain.Logging;
using MediatR;

namespace Definux.Emeraude.Admin.Requests.FetchLogs
{
    /// <summary>
    /// Fetch activity logs.
    /// </summary>
    public class FetchTempFileLogsQuery : FetchLogsQuery<TempFilesLogsViewModel>
    {
        /// <inheritdoc />
        public class FetchTempFileLogsQueryHandler : FetchLogsQueryHandler<FetchTempFileLogsQuery, TempFilesLogsViewModel, TempFileLog, TempFileLogViewModel>
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="FetchTempFileLogsQueryHandler"/> class.
            /// </summary>
            /// <param name="loggerContext"></param>
            /// <param name="entityContext"></param>
            /// <param name="mapper"></param>
            public FetchTempFileLogsQueryHandler(
                ILoggerContext loggerContext,
                IEmContext entityContext,
                IMapper mapper)
                : base(loggerContext, entityContext, mapper)
            {
            }

            /// <inheritdoc />
            protected override Expression<Func<TempFileLog, bool>> BuildSearchQueryExpression(string searchQuery)
            {
                if (string.IsNullOrWhiteSpace(searchQuery))
                {
                    return x => true;
                }

                string normalizedSearchQuery = searchQuery.ToLower();
                int.TryParse(normalizedSearchQuery, out int parsedId);
                return x =>
                    x.Id == parsedId ||
                    x.Path.ToLower().Contains(normalizedSearchQuery);
            }
        }
    }
}