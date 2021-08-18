using System;
using AutoMapper;
using Definux.Emeraude.Application.Models;

namespace Definux.Emeraude.Application.Mapping.Converters
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