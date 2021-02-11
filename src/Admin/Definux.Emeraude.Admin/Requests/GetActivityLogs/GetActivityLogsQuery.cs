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

namespace Definux.Emeraude.Admin.Requests.GetActivityLogs
{
    /// <summary>
    /// Get activity logs with optional page, search query and date filter.
    /// </summary>
    public class GetActivityLogsQuery : LoggerRequest<ActivityLogsViewModel>
    {
        /// <inheritdoc />
        public class GetActivityLogsQueryHandler : LoggerRequestHandler<GetActivityLogsQuery, ActivityLogsViewModel, ActivityLog, ActivityLogViewModel>
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="GetActivityLogsQueryHandler"/> class.
            /// </summary>
            /// <param name="loggerContext"></param>
            /// <param name="entityContext"></param>
            /// <param name="mapper"></param>
            public GetActivityLogsQueryHandler(
                ILoggerContext loggerContext,
                IEmContext entityContext,
                IMapper mapper)
                : base(loggerContext, entityContext, mapper)
            {
            }

            /// <inheritdoc />
            protected override Expression<Func<ActivityLog, bool>> BuildSearchQueryExpression(string searchQuery)
            {
                if (string.IsNullOrWhiteSpace(searchQuery))
                {
                    return x => true;
                }

                string normalizedSearchQuery = searchQuery.ToLower();
                int.TryParse(normalizedSearchQuery, out int parsedId);
                return x =>
                    x.Id == parsedId ||
                    x.Action.ToLower().Contains(normalizedSearchQuery) ||
                    x.Controller.ToLower().Contains(normalizedSearchQuery) ||
                    x.Area.ToLower().Contains(normalizedSearchQuery) ||
                    x.Method.ToLower().Contains(normalizedSearchQuery) ||
                    x.Parameters.ToLower().Contains(normalizedSearchQuery) ||
                    x.Headers.ToLower().Contains(normalizedSearchQuery) ||
                    x.Route.ToLower().Contains(normalizedSearchQuery) ||
                    x.UserAgent.ToLower().Contains(normalizedSearchQuery) ||
                    x.TraceId.ToLower().Contains(normalizedSearchQuery);
            }
        }
    }
}