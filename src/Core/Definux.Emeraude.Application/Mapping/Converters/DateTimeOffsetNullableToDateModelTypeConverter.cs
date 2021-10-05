﻿using System;
using AutoMapper;
using Definux.Emeraude.Application.Models;

namespace Definux.Emeraude.Application.Mapping.Converters
{
    /// <inheritdoc />
    public class DateTimeOffsetNullableToDateModelTypeConverter : ITypeConverter<DateTimeOffset?, DateModel>
    {
        /// <inheritdoc />
        public DateModel Convert(DateTimeOffset? source, DateModel destination, ResolutionContext context)
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
}