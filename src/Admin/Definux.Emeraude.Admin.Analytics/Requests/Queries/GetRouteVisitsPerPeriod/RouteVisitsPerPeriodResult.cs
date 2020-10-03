using System;
using System.Collections.Generic;
using System.Linq;

namespace Definux.Emeraude.Admin.Analytics.Requests.Queries.GetRouteVisitsPerPeriod
{
    /// <summary>
    /// Result of the <see cref="GetRouteVisitsPerPeriodQuery"/>.
    /// </summary>
    public class RouteVisitsPerPeriodResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RouteVisitsPerPeriodResult"/> class.
        /// </summary>
        public RouteVisitsPerPeriodResult()
        {
            this.Data = new List<VisitsPerPeriodPoint>();
        }

        /// <summary>
        /// Name of the route.
        /// </summary>
        public string RouteName { get; set; }

        /// <summary>
        /// Collection of all <see cref="VisitsPerPeriodPoint"/>.
        /// </summary>
        public List<VisitsPerPeriodPoint> Data { get; set; }

        /// <summary>
        /// List of all dates with data.
        /// </summary>
        public List<string> Dates
        {
            get
            {
                return this.Data
                    .Select(x => x.Date.ToString(this.PeriodFormat))
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
        /// Minimum value of the visits.
        /// </summary>
        public int MinVisits
        {
            get
            {
                return this.Visits.Min();
            }
        }

        /// <summary>
        /// Maximum value of the visits.
        /// </summary>
        public int MaxVisits
        {
            get
            {
                return this.Visits.Max();
            }
        }

        /// <summary>
        /// Period type as a string. ('Days', 'Hours').
        /// </summary>
        public string PeriodType { get; set; }

        /// <summary>
        /// Formated date for <see cref="PeriodType"/> of type 'Hours'.
        /// </summary>
        public string HourTypeDate { get; set; }

        /// <summary>
        /// Format string of the period.
        /// </summary>
        private string PeriodFormat
        {
            get
            {
                if (this.PeriodType == "Hours")
                {
                    return "HH:mm";
                }

                return "dd/MM/yyyy";
            }
        }

        /// <summary>
        /// Visits per period point.
        /// </summary>
        public struct VisitsPerPeriodPoint
        {
            /// <summary>
            /// Visits date.
            /// </summary>
            public DateTime Date { get; set; }

            /// <summary>
            /// Amount of visits.
            /// </summary>
            public int Visits { get; set; }

            /// <summary>
            /// Amount of unique visits.
            /// </summary>
            public int UniqueVisits { get; set; }
        }
    }
}
