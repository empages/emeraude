using Definux.Emeraude.Admin.Analytics.Extensions;
using Definux.Emeraude.Application.Common.Interfaces.Logging;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Definux.Emeraude.Admin.Analytics.Requests.Queries.GetRouteVisitsPerPeriod
{
    public class GetRouteVisitsPerPeriodQuery : IRequest<RouteVisitsPerPeriodDto>
    {
        public string Route { get; set; }

        public DateTime? FromDate { get; set; }

        public DateTime? ToDate { get; set; }

        public class GetRouteVisitsPerPeriodQueryHandler : IRequestHandler<GetRouteVisitsPerPeriodQuery, RouteVisitsPerPeriodDto>
        {
            private readonly ILoggerContext context;

            public GetRouteVisitsPerPeriodQueryHandler(ILoggerContext context)
            {
                this.context = context;
            }

            public async Task<RouteVisitsPerPeriodDto> Handle(GetRouteVisitsPerPeriodQuery request, CancellationToken cancellationToken)
            {
                var logs = await this.context
                    .GetLogsPerRouteAndPeriod(request.Route, request.FromDate, request.ToDate)
                    .ToListAsync();

                if (logs.Count == 0)
                {
                    return null;
                }

                RouteVisitsPerPeriodDto result = new RouteVisitsPerPeriodDto();

                result.RouteName = request.Route;
                result.PeriodType = "Days";
                var uniqueDates = logs.Select(x => x.CreatedOn.Date).Distinct().ToList();
                if (uniqueDates.Count > 1)
                {
                    foreach (var date in uniqueDates)
                    {
                        result.Data.Add(new RouteVisitsPerPeriodDto.VisitsPerPeriodPoint
                        {
                            Date = date,
                            Visits = logs.Where(x => x.CreatedOn.Date == date).Count(),
                            UniqueVisits = logs
                                .Where(x => x.CreatedOn.Date == date)
                                .Select(x => x.TraceId)
                                .Distinct()
                                .Count()
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
                        result.Data.Add(new RouteVisitsPerPeriodDto.VisitsPerPeriodPoint
                        {
                            Date = currentDateTime,
                            Visits = logs.Where(x => x.CreatedOn >= currentDateTime && x.CreatedOn <= currentNextDateTime).Count(),
                            UniqueVisits = logs
                                .Where(x => x.CreatedOn >= currentDateTime && x.CreatedOn <= currentNextDateTime)
                                .Select(x => x.TraceId)
                                .Distinct()
                                .Count()
                        });
                    }
                }

                return result;
            }
        }
    }
}
