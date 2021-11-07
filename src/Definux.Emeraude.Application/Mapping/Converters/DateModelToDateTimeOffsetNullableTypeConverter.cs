using System;
using AutoMapper;
using Definux.Emeraude.Application.Models;

namespace Definux.Emeraude.Application.Mapping.Converters
{
    /// <inheritdoc />
    public class DateModelToDateTimeOffsetNullableTypeConverter : ITypeConverter<DateModel, DateTimeOffset?>
    {
        /// <inheritdoc />
        public DateTimeOffset? Convert(DateModel source, DateTimeOffset? destination, ResolutionContext context)
            => source.ToDateTime();
    }
}