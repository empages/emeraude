using System;
using System.Collections.Generic;
using System.Linq;

namespace Definux.Emeraude.Admin.Analytics.Requests.Queries.GetRouteVisitsPerPeriod
{
    public class RouteVisitsPerPeriodDto
    {
        public RouteVisitsPerPeriodDto()
        {
            Data = new List<VisitsPerPeriodPoint>();
        }

        public string RouteName { get; set; }

        public List<VisitsPerPeriodPoint> Data { get; set; }

        public List<string> Dates 
        {
            get
            {
                return Data
                    .Select(x => x.Date.ToString(PeriodFormat))
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

        public string PeriodType { get; set; }

        public string HourTypeDate { get; set; }

        private string PeriodFormat
        {
            get
            {
                if (PeriodType == "Hours")
                {
                    return "HH:mm";
                }

                return "dd/MM/yyyy";
            }
        }

        public struct VisitsPerPeriodPoint
        {
            public DateTime Date { get; set; }

            public int Visits { get; set; }

            public int UniqueVisits { get; set; }
        }
    }
}
