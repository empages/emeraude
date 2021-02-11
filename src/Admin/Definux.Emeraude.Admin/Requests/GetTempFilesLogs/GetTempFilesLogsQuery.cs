using System;
using System.Linq.Expressions;
using AutoMapper;
using Definux.Emeraude.Admin.UI.ViewModels.Logging;
using Definux.Emeraude.Application.Logger;
using Definux.Emeraude.Application.Persistence;
using Definux.Emeraude.Domain.Logging;

namespace Definux.Emeraude.Admin.Requests.GetTempFilesLogs
{
    /// <summary>
    /// Get temp files logs with optional page, search query and date filter.
    /// </summary>
    public class GetTempFilesLogsQuery : LoggerRequest<TempFilesLogsViewModel>
    {
        /// <inheritdoc/>
        public class GetErrorLogsQueryHandler : LoggerRequestHandler<GetTempFilesLogsQuery, TempFilesLogsViewModel, TempFileLog, TempFileLogViewModel>
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="GetErrorLogsQueryHandler"/> class.
            /// </summary>
            /// <param name="loggerContext"></param>
            /// <param name="entityContext"></param>
            /// <param name="mapper"></param>
            public GetErrorLogsQueryHandler(
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