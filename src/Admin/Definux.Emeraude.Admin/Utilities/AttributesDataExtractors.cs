using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Definux.Emeraude.Admin.Utilities
{
    /// <summary>
    /// Utility helper functions that extract attribute data from types and objects.
    /// </summary>
    public static class AttributesDataExtractors
    {
        /// <summary>
        /// Gets all properties from class that contains specific attribute and map it to the dictionary.
        /// </summary>
        /// <param name="targetType"></param>
        /// <typeparam name="TAttribute">Target attribute.</typeparam>
        /// <returns></returns>
        public static Dictionary<PropertyInfo, TAttribute> GetPropertiesWithAttribute<TAttribute>(Type targetType)
            where TAttribute : Attribute
            => targetType
                .GetProperties()
                .Where(x => x.GetCustomAttributes().Any(y => y.GetType() == typeof(TAttribute)))
                .ToDictionary(
                    k => k,
                    v => (TAttribute)v.GetCustomAttributes().First(x => x.GetType() == typeof(TAttribute)));
    }
}