using Definux.Emeraude.Admin.Analytics.Requests.Queries.GetRouteVisitsPerPeriod;
using Definux.Emeraude.Admin.Analytics.Requests.Queries.GetRouteVisitsPerWeekDay;
using Definux.Emeraude.Admin.Analytics.Requests.Queries.GetVisitedUniqueRoutes;
using Definux.Emeraude.Configuration.Authorization;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Definux.Emeraude.Admin.Analytics.Controllers.Api
{
    [Route("/api/analytics/")]
    [Authorize(AuthenticationSchemes = AuthenticationDefaults.AdminAuthenticationScheme)]
    public class AdminAnalyticsApiController : Controller
    {
        private IMediator mediator;

        public AdminAnalyticsApiController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        [Route("get-unique-routes")]
        public async Task<IActionResult> GetUniqueRoutes()
        {
            var result = await this.mediator.Send(new GetVisitedUniqueRoutesQuery());

            return Ok(result);
        }

        [HttpGet]
        [Route("route-visits-per-period")]
        public async Task<IActionResult> GetRouteVisitsPerPeriod(
            [FromQuery(Name = "route")]string route, 
            [FromQuery(Name = "from")]DateTime? fromDate, 
            [FromQuery(Name = "to")]DateTime? toDate)
        {
            var result = await this.mediator.Send(new GetRouteVisitsPerPeriodQuery 
            { 
                Route = route, 
                FromDate = fromDate, 
                ToDate = toDate
            });

            return Ok(result);
        }

        [HttpGet]
        [Route("route-visits-per-week-day")]
        public async Task<IActionResult> GetRouteVisitsPerWeekDay(
            [FromQuery(Name = "route")]string route,
            [FromQuery(Name = "from")]DateTime? fromDate,
            [FromQuery(Name = "to")]DateTime? toDate)
        {
            var result = await this.mediator.Send(new GetRouteVisitsPerWeekDayQuery
            {
                Route = route,
                FromDate = fromDate,
                ToDate = toDate
            });

            return Ok(result);
        }
    }
}
