using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Emeraude.Application.Models;

namespace Emeraude.Presentation.Converters
{
    /// <summary>
    /// Convertor for transform nullable <see cref="DateModel"/> to a JSON.
    /// </summary>
    public class DateModelNullableConverter : JsonConverter<DateModel?>
    {
        /// <inheritdoc />
        public override DateModel? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            DateModel? dateModel = null;
            if (DateModel.TryParse(reader.GetString() ?? string.Empty, out var parsedDateModel))
            {
                dateModel = parsedDateModel;
            }

            return dateModel;
        }

        /// <inheritdoc />
        public override void Write(Utf8JsonWriter writer, DateModel? value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value?.ToString());
        }
    }
}