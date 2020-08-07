using Definux.Emeraude.Admin.Analytics.Extensions;
using Definux.Emeraude.Application.Common.Interfaces.Logging;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Definux.Emeraude.Admin.Analytics.Requests.Queries.GetRouteVisitsPerWeekDay
{
    public class GetRouteVisitsPerWeekDayQuery : IRequest<RouteVisitsPerWeekDayDto>
    {
        public string Route { get; set; }

        public DateTime? FromDate { get; set; }

        public DateTime? ToDate { get; set; }

        public class GetRouteVisitsPerWeekDayQueryHandler : IRequestHandler<GetRouteVisitsPerWeekDayQuery, RouteVisitsPerWeekDayDto>
        {
            private readonly ILoggerContext context;

            public GetRouteVisitsPerWeekDayQueryHandler(ILoggerContext context)
            {
                this.context = context;
            }

            public async Task<RouteVisitsPerWeekDayDto> Handle(GetRouteVisitsPerWeekDayQuery request, CancellationToken cancellationToken)
            {
                var logs = await this.context
                     .GetLogsPerRouteAndPeriod(request.Route, request.FromDate, request.ToDate)
                     .ToListAsync();

                if (logs.Count == 0)
                {
                    return null;
                }

                RouteVisitsPerWeekDayDto result = new RouteVisitsPerWeekDayDto();
                result.RouteName = request.Route;

                for (int i = 0; i < 7; i++)
                {
                    DayOfWeek dayOfWeek = (DayOfWeek)i;

                    result.Data.Add(new RouteVisitsPerWeekDayDto.VisitsPerWeekDayPoint
                    {
                        Day = dayOfWeek,
                        Visits = logs
                            .Where(x => x.CreatedOn.DayOfWeek == dayOfWeek)
                            .Count(),
                        UniqueVisits = logs
                            .Where(x => x.CreatedOn.DayOfWeek == dayOfWeek)
                            .Select(x => x.TraceId)
                            .Distinct()
                            .Count()
                    });
                }

                return result;
            }
        }
    }
}
