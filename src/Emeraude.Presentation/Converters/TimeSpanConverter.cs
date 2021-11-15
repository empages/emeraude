using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Emeraude.Presentation.Converters
{
    /// <summary>
    /// Convertor for transform timespan to a JSON.
    /// </summary>
    public class TimeSpanConverter : JsonConverter<TimeSpan>
    {
        /// <inheritdoc />
        public override TimeSpan Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return TimeSpan.Parse(reader.GetString() ?? "00:00");
        }

        /// <inheritdoc />
        public override void Write(Utf8JsonWriter writer, TimeSpan value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString());
        }
    }
}
