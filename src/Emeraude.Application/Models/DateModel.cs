using System;
using System.Linq;
using Emeraude.Essentials.Base;

namespace Emeraude.Application.Models;

/// <summary>
/// Simplified date model for request/response purposes.
/// </summary>
public struct DateModel
{
    /// <summary>
    /// Default date model format used by Emeraude.
    /// </summary>
    public const string DateModelFormat = "yyyy-MM-dd";

    /// <summary>
    /// Gets default date model.
    /// </summary>
    /// <returns></returns>
    public static DateModel Default
    {
        get
        {
            var defaultDate = default(DateTime);
            return new DateModel
            {
                Year = defaultDate.Year,
                Month = defaultDate.Month,
                Day = defaultDate.Day,
            };
        }
    }

    /// <summary>
    /// Year of the date.
    /// </summary>
    public int Year { get; set; }

    /// <summary>
    /// Month of the date.
    /// </summary>
    public int Month { get; set; }

    /// <summary>
    /// Day of the date.
    /// </summary>
    public int Day { get; set; }

    /// <summary>
    /// Gets whether the model is valid or not.
    /// </summary>
    public bool IsValid => this.Year > 0 && this.Month > 0 && this.Day > 0;

    /// <summary>
    /// Parse model string.
    /// </summary>
    /// <param name="modelString">Should be in format 'year-month-day' (2020-01-01).</param>
    /// <param name="model"></param>
    /// <returns></returns>
    public static bool TryParse(string modelString, out DateModel model)
    {
        model = Default;

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

                try
                {
                    var parsedDate = new DateTime(model.Year, model.Month, model.Day);
                }
                catch (Exception)
                {
                    model = Default;
                }

                parsed = true;
            }
        }

        return parsed;
    }

    /// <summary>
    /// Converts current model to <see cref="DateTime"/>.
    /// </summary>
    /// <returns></returns>
    public DateTime ToDateTime() => this.IsValid ? new DateTime(this.Year, this.Month, this.Day) : default;

    /// <inheritdoc />
    public override string ToString()
    {
        var defaultDate = default(DateTime);
        string result = defaultDate.ToString(DateModelFormat);
        if (this.IsValid)
        {
            result = $"{this.Year:0000}-{this.Month:00}-{this.Day:00}";
        }

        return result;
    }
}