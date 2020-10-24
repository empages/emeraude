using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Definux.Emeraude.Admin.Analytics.Extensions;
using Definux.Emeraude.Application.Logger;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Definux.Emeraude.Admin.Analytics.Requests.Queries.GetRouteVisitsPerPeriod
{
    /// <summary>
    /// Query that returns all routes visits for specified period.
    /// </summary>
    public class GetRouteVisitsPerPeriodQuery : IRequest<RouteVisitsPerPeriodResult>
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
        public class GetRouteVisitsPerPeriodQueryHandler : IRequestHandler<GetRouteVisitsPerPeriodQuery, RouteVisitsPerPeriodResult>
        {
            private readonly ILoggerContext context;

            /// <summary>
            /// Initializes a new instance of the <see cref="GetRouteVisitsPerPeriodQueryHandler"/> class.
            /// </summary>
            /// <param name="context"></param>
            public GetRouteVisitsPerPeriodQueryHandler(ILoggerContext context)
            {
                this.context = context;
            }

            /// <inheritdoc/>
            public async Task<RouteVisitsPerPeriodResult> Handle(GetRouteVisitsPerPeriodQuery request, CancellationToken cancellationToken)
            {
                var logs = await this.context
                    .GetLogsPerRouteAndPeriod(request.Route, request.FromDate, request.ToDate)
                    .ToListAsync();

                if (logs.Count == 0)
                {
                    return null;
                }

                RouteVisitsPerPeriodResult result = new RouteVisitsPerPeriodResult();

                result.RouteName = request.Route;
                result.PeriodType = "Days";
                var uniqueDates = logs.Select(x => x.CreatedOn.Date).Distinct().ToList();
                if (uniqueDates.Count > 1)
                {
                    foreach (var date in uniqueDates)
                    {
                        result.Data.Add(new RouteVisitsPerPeriodResult.VisitsPerPeriodPoint
                        {
                            Date = date,
                            Visits = logs.Where(x => x.CreatedOn.Date == date).Count(),
                            UniqueVisits = logs
                                .Where(x => x.CreatedOn.Date == date)
                                .Select(x => x.TraceId)
                                .Distinct()
                                .Count(),
                        });
                    }
                }
                else
                {
                    result.PeriodType = "Hours";
                    result.HourTypeDate = logs.FirstOrDefault()?.CreatedOn.ToString("dd/MM/yyyy");
                    var minDateTime = logs.Select(x => x.CreatedOn).Min();
                    var maxDateTime = logs.Select(x => x.CreatedOn).Max();
                    int interval = maxDateTime.Hour - minDateTime.Hour;
                    var startDateTime = minDateTime.Date.AddHours(minDateTime.Hour);
                    for (int i = 0; i <= interval; i++)
                    {
                        var currentDateTime = startDateTime.AddHours(i);
                        var currentNextDateTime = currentDateTime.AddHours(1);
                        result.Data.Add(new RouteVisitsPerPeriodResult.VisitsPerPeriodPoint
                        {
                            Date = currentDateTime,
                            Visits = logs.Where(x => x.CreatedOn >= currentDateTime && x.CreatedOn <= currentNextDateTime).Count(),
                            UniqueVisits = logs
                                .Where(x => x.CreatedOn >= currentDateTime && x.CreatedOn <= currentNextDateTime)
                                .Select(x => x.TraceId)
                                .Distinct()
                                .Count(),
                        });
                    }
                }

                return result;
            }
        }
    }
}
