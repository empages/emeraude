using System;
using System.Linq;
using Definux.Emeraude.Interfaces.Models;

namespace Definux.Emeraude.Application.Models
{
    /// <inheritdoc cref="IDateModel"/>
    public struct DateModel : IDateModel
    {
        /// <inheritdoc />
        public int Year { get; set; }

        /// <inheritdoc />
        public int Month { get; set; }

        /// <inheritdoc />
        public int Day { get; set; }

        /// <inheritdoc />
        public bool IsValid => this.Year > 0 && this.Month > 0 && this.Day > 0;

        /// <summary>
        /// Parse model string.
        /// </summary>
        /// <param name="modelString">Should be in format 'year-month-day' (2020-01-01).</param>
        /// <param name="model"></param>
        /// <returns></returns>
        public static bool TryParse(string modelString, out DateModel model)
        {
            model = new DateModel
            {
                Year = -1,
                Month = -1,
                Day = -1,
            };

            bool parsed = false;
            if (!string.IsNullOrWhiteSpace(modelString))
            {
                string[] modelElements = modelString.Split('-');
                if (modelElements.Length == 3 && modelElements.All(x => int.TryParse(x, out _)))
                {
                    model = new DateModel
                    {
                        Year = int.Parse(modelElements[0]),
                        Month = int.Parse(modelElements[1]),
                        Day = int.Parse(modelElements[2]),
                    };

                    parsed = true;
                }
            }

            return parsed;
        }

        /// <inheritdoc />
        public DateTime ToDateTime() => this.IsValid ? new DateTime(this.Year, this.Month, this.Day) : default;
    }
}