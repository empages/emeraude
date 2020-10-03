using System;
using System.Linq;
using Definux.Emeraude.Application.Common.Interfaces.Logging;
using Definux.Emeraude.Domain.Logging;

namespace Definux.Emeraude.Admin.Analytics.Extensions
{
    /// <summary>
    /// Extensions for <see cref="ILoggerContext"/>.
    /// </summary>
    public static class LoggerContextExtensions
    {
        /// <summary>
        /// Get activity logs for specified route and period.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="route"></param>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <returns></returns>
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
