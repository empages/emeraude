using System;
using AutoMapper;
using Definux.Emeraude.Application.Models;

namespace Definux.Emeraude.Application.Mapping.Converters
{
    /// <inheritdoc />
    public class DateTimeNullableToDateModelTypeConverter : ITypeConverter<DateTime?, DateModel>
    {
        /// <inheritdoc />
        public DateModel Convert(DateTime? source, DateModel destination, ResolutionContext context)
        {
            DateModel result = new DateModel
            {
                Year = -1,
                Month = -1,
                Day = -1,
            };

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
}