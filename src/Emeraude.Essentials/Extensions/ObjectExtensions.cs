using System;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Emeraude.Essentials.Extensions
{
    /// <summary>
    /// Extensions for <see cref="object"/>.
    /// </summary>
    public static class ObjectExtensions
    {
        /// <summary>
        /// Converts object to serialized string that allows easier logging.
        /// </summary>
        /// <param name="sourceObject"></param>
        /// <param name="maxDepth"></param>
        /// <returns></returns>
        public static string ToLoggingString(this object sourceObject, int maxDepth = 5)
        {
            if (sourceObject == null)
            {
                return null;
            }

            try
            {
                var serializedObject = JsonConvert.SerializeObject(sourceObject, new JsonSerializerSettings
                {
                    ContractResolver = new DefaultContractResolver
                    {
                        NamingStrategy = new DefaultNamingStrategy(),
                    },
                    Formatting = Formatting.Indented,
                    MaxDepth = maxDepth,
                });

                if (string.IsNullOrWhiteSpace(serializedObject))
                {
                    return serializedObject;
                }

                serializedObject = Regex.Replace(serializedObject, @"\t|\n|\r", string.Empty);
                serializedObject = Regex.Replace(serializedObject, @"\s+", " ");

                return serializedObject;
            }
            catch (Exception)
            {
                return "[Object cannot be serialized]";
            }
        }
    }
}