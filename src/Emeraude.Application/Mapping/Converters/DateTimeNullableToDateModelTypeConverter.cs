using System;
using AutoMapper;
using Emeraude.Application.Models;

namespace Emeraude.Application.Mapping.Converters;

/// <inheritdoc />
public class DateTimeNullableToDateModelTypeConverter : ITypeConverter<DateTime?, DateModel>
{
    /// <inheritdoc />
    public DateModel Convert(DateTime? source, DateModel destination, ResolutionContext context)
    {
        DateModel result = DateModel.Default;

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