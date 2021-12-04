using System;
using AutoMapper;
using Emeraude.Application.Models;

namespace Emeraude.Application.Mapping.Converters;

/// <inheritdoc />
public class DateModelNullableToDateTimeOffsetTypeConverter : ITypeConverter<DateModel?, DateTimeOffset>
{
    /// <inheritdoc />
    public DateTimeOffset Convert(DateModel? source, DateTimeOffset destination, ResolutionContext context)
        => source?.ToDateTime() ?? default;
}