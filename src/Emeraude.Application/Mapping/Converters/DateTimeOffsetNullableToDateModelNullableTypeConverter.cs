using System;
using AutoMapper;
using Emeraude.Application.Models;

namespace Emeraude.Application.Mapping.Converters;

/// <inheritdoc />
public class DateTimeOffsetNullableToDateModelNullableTypeConverter : ITypeConverter<DateTimeOffset?, DateModel?>
{
    /// <inheritdoc />
    public DateModel? Convert(DateTimeOffset? source, DateModel? destination, ResolutionContext context)
    {
        DateModel? result = null;
        if (source.HasValue)
        {
            result = new DateModel
            {
                Year = source.Value.Year,
                Month = source.Value.Month,
                Day = source.Value.Day,
            };
        }

        return result;
    }
}