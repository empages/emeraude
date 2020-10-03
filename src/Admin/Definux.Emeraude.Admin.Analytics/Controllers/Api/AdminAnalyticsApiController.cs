using System;
using System.Threading.Tasks;
using Definux.Emeraude.Admin.Analytics.Requests.Queries.GetRouteVisitsPerPeriod;
using Definux.Emeraude.Admin.Analytics.Requests.Queries.GetRouteVisitsPerWeekDay;
using Definux.Emeraude.Admin.Analytics.Requests.Queries.GetVisitedUniqueRoutes;
using Definux.Emeraude.Configuration.Authorization;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Definux.Emeraude.Admin.Analytics.Controllers.Api
{
    /// <summary>
    /// Admin analytics API controller that contains all analytics endpoints for accessing internal application data.
    /// </summary>
    [Route("/api/analytics/")]
    [Authorize(AuthenticationSchemes = AuthenticationDefaults.AdminAuthenticationScheme)]
    public class AdminAnalyticsApiController : Controller
    {
        private IMediator mediator;

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminAnalyticsApiController"/> class.
        /// </summary>
        /// <param name="mediator"></param>
        public AdminAnalyticsApiController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        /// <summary>
        /// Get all visited unique routes.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("get-unique-routes")]
        public async Task<IActionResult> GetUniqueRoutes()
        {
            var result = await this.mediator.Send(new GetVisitedUniqueRoutesQuery());

            return this.Ok(result);
        }

        /// <summary>
        /// Get all visited unique routes per period.
        /// </summary>
        /// <param name="route"></param>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <returns></returns>
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
                ToDate = toDate,
            });

            return this.Ok(result);
        }

        /// <summary>
        /// Get all visited unique routes per week.
        /// </summary>
        /// <param name="route"></param>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <returns></returns>
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
                ToDate = toDate,
            });

            return this.Ok(result);
        }
    }
}
