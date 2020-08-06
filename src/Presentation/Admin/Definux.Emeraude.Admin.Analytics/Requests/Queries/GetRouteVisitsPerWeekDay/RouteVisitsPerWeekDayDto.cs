using System;
using System.Collections.Generic;
using System.Linq;

namespace Definux.Emeraude.Admin.Analytics.Requests.Queries.GetRouteVisitsPerWeekDay
{
    public class RouteVisitsPerWeekDayDto
    {
        public RouteVisitsPerWeekDayDto()
        {
            Data = new List<VisitsPerWeekDayPoint>();
        }

        public string RouteName { get; set; }

        public List<VisitsPerWeekDayPoint> Data { get; set; }

        public List<string> Days
        {
            get
            {
                return Data
                    .Select(x => x.Day.ToString())
                    .ToList();
            }
        }

        public List<int> Visits
        {
            get
            {
                return Data
                    .Select(x => x.Visits)
                    .ToList();
            }
        }

        public List<int> UniqueVisits
        {
            get
            {
                return Data
                    .Select(x => x.UniqueVisits)
                    .ToList();
            }
        }

        public int MinVisits
        {
            get
            {
                return Visits.Min();
            }
        }

        public int MaxVisits
        {
            get
            {
                return Visits.Max();
            }
        }

        public struct VisitsPerWeekDayPoint
        {
            public DayOfWeek Day { get; set; }

            public int Visits { get; set; }

            public int UniqueVisits { get; set; }
        }
    }
}
