using Definux.Emeraude.Application.Common.Interfaces.Logging;
using Definux.Emeraude.Domain.Logging;
using System;
using System.Linq;

namespace Definux.Emeraude.Admin.Analytics.Extensions
{
    public static class LoggerContextExtensions
    {
        public static IQueryable<ActivityLog> GetLogsPerRouteAndPeriod(
            this ILoggerContext context, 
            string route, 
            DateTime? fromDate = null, 
            DateTime? toDate = null)
        {
            if (!fromDate.HasValue)
            {
                fromDate = DateTime.Now.Date;
            }

            if (!toDate.HasValue)
            {
                toDate = DateTime.Now.Date;
            }

            var logs = context
                .ActivityLogs
                .AsQueryable()
                .Where(
                    x =>
                    x.Route.ToLower() == route.ToLower() &&
                    x.CreatedOn.Date >= fromDate.Value.Date &&
                    x.CreatedOn.Date <= toDate.Value.Date)
                .OrderBy(x => x.CreatedOn)
                .AsQueryable();

            return logs;
        }
    }
}
