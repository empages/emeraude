using System;
using Newtonsoft.Json;

namespace Emeraude.Presentation.Converters
{
    /// <summary>
    /// Convertor for transform nullable timespan to a JSON.
    /// </summary>
    public class TimeSpanNullableNewtonsoftConverter : JsonConverter<TimeSpan?>
    {
        /// <inheritdoc />
        public override void WriteJson(JsonWriter writer, TimeSpan? value, JsonSerializer serializer)
        {
            writer.WriteValue(value?.ToString());
        }

        /// <inheritdoc />
        public override TimeSpan? ReadJson(JsonReader reader, Type objectType, TimeSpan? existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var value = reader.Value?.ToString() ?? string.Empty;
            if (string.IsNullOrWhiteSpace(value))
            {
                return null;
            }

            return TimeSpan.Parse(value);
        }
    }
}