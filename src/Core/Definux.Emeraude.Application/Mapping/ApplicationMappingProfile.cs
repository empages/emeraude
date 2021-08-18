using System;
using AutoMapper;
using Definux.Emeraude.Application.Mapping.Converters;
using Definux.Emeraude.Application.Models;

namespace Definux.Emeraude.Application.Mapping
{
    /// <summary>
    /// Default Emeraude application mapping profile.
    /// </summary>
    public class ApplicationMappingProfile : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationMappingProfile"/> class.
        /// </summary>
        public ApplicationMappingProfile()
        {
            this.CreateMap<DateTime, DateModel>().ConvertUsing<DateTimeToDateModelTypeConverter>();
            this.CreateMap<DateTime?, DateModel>().ConvertUsing<DateTimeNullableToDateModelTypeConverter>();
            this.CreateMap<DateTime, DateModel?>().ConvertUsing<DateTimeToDateModelNullableTypeConverter>();
            this.CreateMap<DateTime?, DateModel?>().ConvertUsing<DateTimeNullableToDateModelNullableTypeConverter>();
            this.CreateMap<DateTimeOffset, DateModel>().ConvertUsing<DateTimeOffsetToDateModelTypeConverter>();
            this.CreateMap<DateTimeOffset?, DateModel>().ConvertUsing<DateTimeOffsetNullableToDateModelTypeConverter>();
            this.CreateMap<DateTimeOffset, DateModel?>().ConvertUsing<DateTimeOffsetToDateModelNullableTypeConverter>();
            this.CreateMap<DateTimeOffset?, DateModel?>().ConvertUsing<DateTimeOffsetNullableToDateModelNullableTypeConverter>();

            this.CreateMap<DateModel, DateTime>().ConvertUsing<DateModelToDateTimeTypeConverter>();
            this.CreateMap<DateModel, DateTime?>().ConvertUsing<DateModelToDateTimeNullableTypeConverter>();
            this.CreateMap<DateModel?, DateTime>().ConvertUsing<DateModelNullableToDateTimeTypeConverter>();
            this.CreateMap<DateModel?, DateTime?>().ConvertUsing<DateModelNullableToDateTimeNullableTypeConverter>();
            this.CreateMap<DateModel, DateTimeOffset>().ConvertUsing<DateModelToDateTimeOffsetTypeConverter>();
            this.CreateMap<DateModel, DateTimeOffset?>().ConvertUsing<DateModelToDateTimeOffsetNullableTypeConverter>();
            this.CreateMap<DateModel?, DateTimeOffset>().ConvertUsing<DateModelNullableToDateTimeOffsetTypeConverter>();
            this.CreateMap<DateModel?, DateTimeOffset?>().ConvertUsing<DateModelNullableToDateTimeOffsetNullableTypeConverter>();
        }
    }
}