using System;
using System.Collections.Generic;
using System.Linq;

namespace Definux.Emeraude.Admin.Analytics.Requests.Queries.GetRouteVisitsPerWeekDay
{
    /// <summary>
    /// Result of the <see cref="GetRouteVisitsPerWeekDayQuery"/>.
    /// </summary>
    public class RouteVisitsPerWeekDayResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RouteVisitsPerWeekDayResult"/> class.
        /// </summary>
        public RouteVisitsPerWeekDayResult()
        {
            this.Data = new List<VisitsPerWeekDayPoint>();
        }

        /// <summary>
        /// Name of the route.
        /// </summary>
        public string RouteName { get; set; }

        /// <summary>
        /// Collection of all <see cref="VisitsPerWeekDayPoint"/>.
        /// </summary>
        public List<VisitsPerWeekDayPoint> Data { get; set; }

        /// <summary>
        /// List of all days of the week.
        /// </summary>
        public List<string> Days
        {
            get
            {
                return this.Data
                    .Select(x => x.Day.ToString())
                    .ToList();
            }
        }

        /// <summary>
        /// List of all visits.
        /// </summary>
        public List<int> Visits
        {
            get
            {
                return this.Data
                    .Select(x => x.Visits)
                    .ToList();
            }
        }

        /// <summary>
        /// List of all unique visits.
        /// </summary>
        public List<int> UniqueVisits
        {
            get
            {
                return this.Data
                    .Select(x => x.UniqueVisits)
                    .ToList();
            }
        }

        /// <summary>
        /// Minimum value of the visits for the day.
        /// </summary>
        public int MinVisits
        {
            get
            {
                return this.Visits.Min();
            }
        }

        /// <summary>
        /// Maximum value of the visits for the day.
        /// </summary>
        public int MaxVisits
        {
            get
            {
                return this.Visits.Max();
            }
        }

        /// <summary>
        /// Visits per week day point.
        /// </summary>
        public struct VisitsPerWeekDayPoint
        {
            /// <summary>
            /// Day of the week.
            /// </summary>
            public DayOfWeek Day { get; set; }

            /// <summary>
            /// Amount visits.
            /// </summary>
            public int Visits { get; set; }

            /// <summary>
            /// Amount unique visits.
            /// </summary>
            public int UniqueVisits { get; set; }
        }
    }
}
