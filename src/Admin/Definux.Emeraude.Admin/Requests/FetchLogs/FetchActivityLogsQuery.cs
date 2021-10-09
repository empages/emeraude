using System;
using System.Linq.Expressions;
using AutoMapper;
using Definux.Emeraude.Admin.UI.Models.Logging;
using Definux.Emeraude.Application.Logger;
using Definux.Emeraude.Application.Persistence;
using Definux.Emeraude.Domain.Logging;

namespace Definux.Emeraude.Admin.Requests.FetchLogs
{
    /// <summary>
    /// Fetch activity logs.
    /// </summary>
    public class FetchActivityLogsQuery : FetchLogsQuery<ActivityLogsModel>
    {
        /// <inheritdoc />
        public class FetchActivityLogsQueryHandler : FetchLogsQueryHandler<FetchActivityLogsQuery, ActivityLogsModel, ActivityLog, ActivityLogModel>
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="FetchActivityLogsQueryHandler"/> class.
            /// </summary>
            /// <param name="loggerContext"></param>
            /// <param name="entityContext"></param>
            /// <param name="mapper"></param>
            public FetchActivityLogsQueryHandler(
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