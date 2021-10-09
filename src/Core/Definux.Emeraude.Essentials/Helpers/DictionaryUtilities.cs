using System;
using System.Collections.Generic;
using System.Linq;
using Definux.Emeraude.Essentials.Extensions;

namespace Definux.Emeraude.Essentials.Helpers
{
    /// <summary>
    /// Utilities for dictionary type.
    /// </summary>
    public static class DictionaryUtilities
    {
        /// <summary>
        /// Maps dictionary to class instance.
        /// </summary>
        /// <param name="classType"></param>
        /// <param name="dictionary"></param>
        /// <returns></returns>
        public static object NewClassInstanceFromDictionary(Type classType, IDictionary<string, object> dictionary)
        {
            var classInstance = Activator.CreateInstance(classType);
            var properties = classType.GetProperties();
            foreach (var property in properties)
            {
                if (!dictionary.Any(x => x.Key.Equals(property.Name, StringComparison.InvariantCultureIgnoreCase)))
                {
                    continue;
                }

                var item = dictionary.First(x => x.Key.Equals(property.Name, StringComparison.InvariantCultureIgnoreCase));

                var tempPropertyType = classType.GetProperty(property.Name)?.PropertyType;
                if (tempPropertyType == null)
                {
                    continue;
                }

                object propertyValue = null;
                var propertyType = Nullable.GetUnderlyingType(tempPropertyType) ?? tempPropertyType;
                if (!tempPropertyType.IsNullableType() && item.Value == null)
                {
                    propertyValue = propertyType.GetDefaultValue();
                }
                else if (tempPropertyType.IsNullableType() && item.Value == null)
                {
                    propertyValue = null;
                }
                else
                {
                    propertyValue = Convert.ChangeType(item.Value, propertyType);
                }

                classType.GetProperty(property.Name)?.SetValue(classInstance, propertyValue, null);
            }

            return classInstance;
        }

        /// <summary>
        /// Creates class instance with populated properties by using dictionary.
        /// </summary>
        /// <param name="dictionary"></param>
        /// <typeparam name="TClass">Type of the object.</typeparam>
        /// <returns></returns>
        public static TClass NewClassInstanceFromDictionary<TClass>(IDictionary<string, object> dictionary)
            where TClass : class, new()
            => NewClassInstanceFromDictionary(typeof(TClass), dictionary) as TClass;
    }
}