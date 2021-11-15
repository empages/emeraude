using System;
using Emeraude.Application.Models;
using Newtonsoft.Json;

namespace Emeraude.Presentation.Converters
{
    /// <summary>
    /// Convertor for transform nullable <see cref="DateModel"/> to a JSON.
    /// </summary>
    public class DateModelNullableNewtonsoftConverter : JsonConverter<DateModel?>
    {
        /// <inheritdoc />
        public override void WriteJson(JsonWriter writer, DateModel? value, JsonSerializer serializer)
        {
            writer.WriteValue(value?.ToString());
        }

        /// <inheritdoc />
        public override DateModel? ReadJson(JsonReader reader, Type objectType, DateModel? existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            DateModel? dateModel = null;
            var value = reader.Value?.ToString() ?? string.Empty;
            if (DateModel.TryParse(value, out var parsedDateModel))
            {
                dateModel = parsedDateModel;
            }

            return dateModel;
        }
    }
}