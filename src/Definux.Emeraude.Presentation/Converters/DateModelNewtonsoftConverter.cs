using System;
using Definux.Emeraude.Application.Models;
using Newtonsoft.Json;

namespace Definux.Emeraude.Presentation.Converters
{
    /// <summary>
    /// Convertor for transform <see cref="DateModel"/> to a JSON.
    /// </summary>
    public class DateModelNewtonsoftConverter : JsonConverter<DateModel>
    {
        /// <inheritdoc />
        public override void WriteJson(JsonWriter writer, DateModel value, JsonSerializer serializer)
        {
            writer.WriteValue(value.ToString());
        }

        /// <inheritdoc />
        public override DateModel ReadJson(JsonReader reader, Type objectType, DateModel existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var value = reader.Value?.ToString() ?? string.Empty;
            if (!DateModel.TryParse(value, out var dateModel))
            {
                dateModel = DateModel.Default;
            }

            return dateModel;
        }
    }
}