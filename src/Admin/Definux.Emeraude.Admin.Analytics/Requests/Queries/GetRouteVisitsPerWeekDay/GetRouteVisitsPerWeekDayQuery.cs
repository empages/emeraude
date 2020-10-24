using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Definux.Emeraude.Admin.Analytics.Extensions;
using Definux.Emeraude.Application.Logger;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Definux.Emeraude.Admin.Analytics.Requests.Queries.GetRouteVisitsPerWeekDay
{
    /// <summary>
    /// Query that returns all route visits per day of the week for specified period.
    /// </summary>
    public class GetRouteVisitsPerWeekDayQuery : IRequest<RouteVisitsPerWeekDayResult>
    {
        /// <summary>
        /// Target route.
        /// </summary>
        public string Route { get; set; }

        /// <summary>
        /// Period start date.
        /// </summary>
        public DateTime? FromDate { get; set; }

        /// <summary>
        /// Period end date.
        /// </summary>
        public DateTime? ToDate { get; set; }

        /// <inheritdoc/>
        public class GetRouteVisitsPerWeekDayQueryHandler : IRequestHandler<GetRouteVisitsPerWeekDayQuery, RouteVisitsPerWeekDayResult>
        {
            private readonly ILoggerContext context;

            /// <summary>
            /// Initializes a new instance of the <see cref="GetRouteVisitsPerWeekDayQueryHandler"/> class.
            /// </summary>
            /// <param name="context"></param>
            public GetRouteVisitsPerWeekDayQueryHandler(ILoggerContext context)
            {
                this.context = context;
            }

            /// <inheritdoc/>
            public async Task<RouteVisitsPerWeekDayResult> Handle(GetRouteVisitsPerWeekDayQuery request, CancellationToken cancellationToken)
            {
                var logs = await this.context
                     .GetLogsPerRouteAndPeriod(request.Route, request.FromDate, request.ToDate)
                     .ToListAsync();

                if (logs.Count == 0)
                {
                    return null;
                }

                RouteVisitsPerWeekDayResult result = new RouteVisitsPerWeekDayResult();
                result.RouteName = request.Route;

                for (int i = 0; i < 7; i++)
                {
                    DayOfWeek dayOfWeek = (DayOfWeek)i;

                    result.Data.Add(new RouteVisitsPerWeekDayResult.VisitsPerWeekDayPoint
                    {
                        Day = dayOfWeek,
                        Visits = logs
                            .Where(x => x.CreatedOn.DayOfWeek == dayOfWeek)
                            .Count(),
                        UniqueVisits = logs
                            .Where(x => x.CreatedOn.DayOfWeek == dayOfWeek)
                            .Select(x => x.TraceId)
                            .Distinct()
                            .Count(),
                    });
                }

                return result;
            }
        }
    }
}
