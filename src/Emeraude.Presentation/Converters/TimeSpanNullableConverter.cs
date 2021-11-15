using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Emeraude.Presentation.Converters
{
    /// <summary>
    /// Convertor for transform nullable timespan to a JSON.
    /// </summary>
    public class TimeSpanNullableConverter : JsonConverter<TimeSpan?>
    {
        /// <inheritdoc />
        public override TimeSpan? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (string.IsNullOrWhiteSpace(reader.GetString()))
            {
                return null;
            }

            return TimeSpan.Parse(reader.GetString() ?? "00:00");
        }

        /// <inheritdoc />
        public override void Write(Utf8JsonWriter writer, TimeSpan? value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value?.ToString());
        }
    }
}