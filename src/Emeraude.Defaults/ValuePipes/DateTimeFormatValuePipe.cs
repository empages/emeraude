using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Emeraude.Application.Admin.EmPages.Schema;
using Emeraude.Application.Models;
using Emeraude.Essentials.Base;

namespace Emeraude.Defaults.ValuePipes;

/// <summary>
/// Default implementation of value pipe for date time formatting.
/// The first parameter is optional and represent the format.
/// The default format is representing format on date without date.
/// </summary>
public class DateTimeFormatValuePipe : IValuePipe
{
    private string formatString = EmSystemFormats.DateFormat;

    /// <inheritdoc/>
    public async Task PrepareAsync(IEnumerable<object> targetObjects, string[] parameters)
    {
        if (parameters.Any())
        {
            this.formatString = parameters.First();
        }

        await Task.CompletedTask;
    }

    /// <inheritdoc/>
    public async Task<object> ConvertAsync(object value)
    {
        if (value == null)
        {
            return null;
        }

        if (DateTime.TryParse(value?.ToString(), out var dateTime))
        {
            return dateTime.ToString(this.formatString);
        }

        if (DateModel.TryParse(value?.ToString(), out var dateModel))
        {
            return dateModel.ToDateTime().ToString(this.formatString);
        }

        if (DateTimeOffset.TryParse(value?.ToString(), out var dateTimeOffset))
        {
            return dateTimeOffset.Date.ToString(this.formatString);
        }

        return value;
    }
}