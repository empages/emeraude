using System;
using AutoMapper;
using Emeraude.Application.Models;

namespace Emeraude.Application.Mapping.Converters
{
    /// <inheritdoc />
    public class DateTimeOffsetToDateModelNullableTypeConverter : ITypeConverter<DateTimeOffset, DateModel?>
    {
        /// <inheritdoc />
        public DateModel? Convert(DateTimeOffset source, DateModel? destination, ResolutionContext context)
        {
            return new DateModel
            {
                Year = source.Year,
                Month = source.Month,
                Day = source.Day,
            };
        }
    }
}