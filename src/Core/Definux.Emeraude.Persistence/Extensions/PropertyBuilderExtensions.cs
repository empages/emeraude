using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Newtonsoft.Json;

namespace Definux.Emeraude.Persistence.Extensions
{
    /// <summary>
    /// Extensions for <see cref="PropertyBuilder"/>.
    /// </summary>
    public static class PropertyBuilderExtensions
    {
        /// <summary>
        /// Make the conversion between enum array and string.
        /// </summary>
        /// <typeparam name="TEnum">Enum with string name and value in Int32.</typeparam>
        /// <param name="propertyBuilder"></param>
        /// <returns></returns>
        public static PropertyBuilder<TEnum[]> HasEnumArrayConversion<TEnum>(this PropertyBuilder<TEnum[]> propertyBuilder)
            where TEnum : Enum
        {
            var type = typeof(TEnum);
            if (type.IsEnum)
            {
                var valueConverter = new ValueConverter<TEnum[], string>(
                        x => string.Join(',', x.Select(y => Convert.ToInt32(Enum.ToObject(type, y)).ToString())),
                        x => x.Split(',', StringSplitOptions.RemoveEmptyEntries).Select(y => (TEnum)Enum.Parse(type, y)).ToArray());

                var valueComparer = new ValueComparer<TEnum[]>(
                    (c1, c2) => c1.SequenceEqual(c2),
                    c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
                    c => c.ToArray());

                propertyBuilder.HasConversion(valueConverter);
                propertyBuilder.Metadata.SetValueComparer(valueComparer);

                return propertyBuilder;
            }

            throw new ArgumentException("Generic parameter has to be enum type.");
        }

        /// <summary>
        /// Make the conversion between object array and string.
        /// </summary>
        /// <typeparam name="TType">Object which is easy for serialization.</typeparam>
        /// <param name="propertyBuilder"></param>
        /// <returns></returns>
        public static PropertyBuilder<TType[]> HasObjectArrayToJsonConversion<TType>(this PropertyBuilder<TType[]> propertyBuilder)
        {
            var valueConverter = new ValueConverter<TType[], string>(
                x => JsonConvert.SerializeObject(x, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }),
                x => JsonConvert.DeserializeObject<TType[]>(x, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }));

            var valueComparer = new ValueComparer<TType[]>(
                (c1, c2) => c1.SequenceEqual(c2),
                c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
                c => c.ToArray());

            propertyBuilder.HasConversion(valueConverter);
            propertyBuilder.Metadata.SetValueComparer(valueComparer);

            return propertyBuilder;
        }
    }
}
