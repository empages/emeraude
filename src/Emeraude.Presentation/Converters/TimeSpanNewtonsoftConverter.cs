using System;
using System.Text.Json;
using Newtonsoft.Json;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;

namespace Emeraude.Presentation.Converters
{
    /// <summary>
    /// Convertor for transform timespan to a JSON.
    /// </summary>
    public class TimeSpanNewtonsoftConverter : JsonConverter<TimeSpan>
    {
        /// <inheritdoc />
        public override void WriteJson(JsonWriter writer, TimeSpan value, JsonSerializer serializer)
        {
            writer.WriteValue(value.ToString());
        }

        /// <inheritdoc />
        public override TimeSpan ReadJson(JsonReader reader, Type objectType, TimeSpan existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var value = reader.Value?.ToString() ?? "00:00";
            return TimeSpan.Parse(value);
        }
    }
}
