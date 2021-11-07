using System;
using AutoMapper;
using Definux.Emeraude.Application.Models;

namespace Definux.Emeraude.Application.Mapping.Converters
{
    /// <inheritdoc />
    public class DateModelToDateTimeNullableTypeConverter : ITypeConverter<DateModel, DateTime?>
    {
        /// <inheritdoc />
        public DateTime? Convert(DateModel source, DateTime? destination, ResolutionContext context)
            => source.ToDateTime();
    }
}