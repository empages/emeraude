using System;
using System.Collections.Generic;
using System.Linq;
using Emeraude.Essentials.Attributes;
using Emeraude.Essentials.Extensions;
using Emeraude.Essentials.Models;

namespace Emeraude.Essentials.Helpers
{
    /// <summary>
    /// Enumeration utilities.
    /// </summary>
    public static class EnumUtilities
    {
        /// <summary>
        /// Gets enum by its value. Method supports nullable enumerations.
        /// </summary>
        /// <param name="enumType"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static object GetEnum(Type enumType, object value)
        {
            if (enumType == null)
            {
                throw new ArgumentNullException(nameof(enumType));
            }

            var actualEnumType = enumType.IsNullableType() ? Nullable.GetUnderlyingType(enumType) : enumType;
            var enumValueItems = GetEnumValueItems(actualEnumType);
            string enumName = null;
            if (enumType.IsNullableType())
            {
                if (!string.IsNullOrWhiteSpace(value?.ToString()))
                {
                    var parsedValue = int.Parse(value?.ToString() ?? string.Empty);
                    enumName = enumValueItems
                        .Where(x => x.Value == parsedValue)
                        .Select(x => x.OriginalName)
                        .FirstOrDefault();
                }
            }
            else
            {
                var parsedValue = int.Parse(value?.ToString() ?? string.Empty);
                enumName = enumValueItems
                    .Where(x => x.Value == parsedValue)
                    .Select(x => x.OriginalName)
                    .First();
            }

            return string.IsNullOrEmpty(enumName) ? null : Enum.Parse(actualEnumType, enumName);
        }

        /// <summary>
        /// Converts enumeration type to dictionary with values and names of the enumeration.
        /// </summary>
        /// <param name="enumType"></param>
        /// <returns></returns>
        public static Dictionary<int, string> GetEnumList(Type enumType)
        {
            if (enumType.BaseType != typeof(Enum))
            {
                return null;
            }

            var enumValues = enumType.GetEnumValues();
            Dictionary<int, string> result = new Dictionary<int, string>();
            foreach (var value in enumValues)
            {
                result[(int)Enum.Parse(enumType, value.ToString())] = StringUtilities.SplitWordsByCapitalLetters(value.ToString());
            }

            return result;
        }

        /// <summary>
        /// Gets <see cref="EnumValueItem"/> from the enumeration value and assembly type name.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="enumTypeName"></param>
        /// <returns></returns>
        public static EnumValueItem GetEnumItemFromTypeByValue(int value, string enumTypeName)
        {
            EnumValueItem result = null;
            var enumValues = GetEnumValueItems(enumTypeName);
            if (enumValues != null && enumValues.Any(x => x.Value == value))
            {
                result = enumValues.FirstOrDefault(x => x.Value == value);
            }

            return result;
        }

        /// <summary>
        /// Gets collection of <see cref="EnumValueItem"/> for specified enumeration assembly type name.
        /// </summary>
        /// <param name="enumTypeName"></param>
        /// <returns></returns>
        public static IEnumerable<EnumValueItem> GetEnumValueItems(string enumTypeName)
        {
            try
            {
                var enumType = GetEnumType(enumTypeName);
                if (enumType == null)
                {
                    return null;
                }

                return GetEnumValueItems(enumType);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        /// <summary>
        /// Gets collection of <see cref="EnumValueItem"/> for specified enumeration type.
        /// </summary>
        /// <param name="enumType"></param>
        /// <returns></returns>
        public static IEnumerable<EnumValueItem> GetEnumValueItems(Type enumType)
        {
            try
            {
                var actualEnumType = enumType.IsNullableType() ? Nullable.GetUnderlyingType(enumType) : enumType;

                if (actualEnumType.BaseType != typeof(Enum))
                {
                    return null;
                }

                List<EnumValueItem> result = new List<EnumValueItem>();

                var enumValues = actualEnumType.GetEnumValues();
                foreach (var value in enumValues)
                {
                    int enumValue = (int)Enum.Parse(actualEnumType, value.ToString());
                    var memberInfo = actualEnumType.GetMember(actualEnumType.GetEnumName(value));
                    var keyAttribute = memberInfo.First().GetAttribute<EnumKeyAttribute>();
                    var nameAttribute = memberInfo.First().GetAttribute<EnumNameAttribute>();

                    string name = value.ToString();
                    string originalName = name;
                    string friendlyName = StringUtilities.SplitWordsByCapitalLetters(originalName);
                    string key = StringUtilities.ConvertToKey(actualEnumType.Name + name);

                    if (keyAttribute != null)
                    {
                        key = keyAttribute.Key;
                    }

                    name = nameAttribute != null ? nameAttribute.Name : friendlyName;

                    result.Add(new EnumValueItem
                    {
                        Value = enumValue,
                        Name = name,
                        OriginalName = originalName,
                        Key = key,
                    });
                }

                return result;
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Gets enumeration type from the enumeration assembly name.
        /// </summary>
        /// <param name="enumName"></param>
        /// <returns></returns>
        public static Type GetEnumType(string enumName)
        {
            foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
            {
                var type = assembly.GetType(enumName);
                if (type == null)
                {
                    continue;
                }

                if (type.IsEnum)
                {
                    return type;
                }
            }

            return null;
        }
    }
}