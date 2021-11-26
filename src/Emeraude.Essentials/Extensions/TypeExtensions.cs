using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using Emeraude.Essentials.Helpers;

namespace Emeraude.Essentials.Extensions
{
    /// <summary>
    /// Extensions of <see cref="Type"/>.
    /// </summary>
    public static class TypeExtensions
    {
        /// <summary>
        /// Check whether the <see cref="PropertyInfo"/> has the specified attribute.
        /// </summary>
        /// <typeparam name="T">Attribute type.</typeparam>
        /// <param name="propertyInfo"></param>
        /// <returns></returns>
        public static bool HasAttribute<T>(this PropertyInfo propertyInfo)
        {
            return propertyInfo.GetCustomAttributes(typeof(T), true).Any();
        }

        /// <summary>
        /// Check whether the <see cref="MethodInfo"/> has the specified attribute.
        /// </summary>
        /// <typeparam name="T">Attribute type.</typeparam>
        /// <param name="methodInfo"></param>
        /// <returns></returns>
        public static bool HasAttribute<T>(this MethodInfo methodInfo)
        {
            return methodInfo.GetCustomAttributes(typeof(T), true).Any();
        }

        /// <summary>
        /// Check whether the <see cref="MemberInfo"/> has the specified attribute.
        /// </summary>
        /// <typeparam name="T">Attribute type.</typeparam>
        /// <param name="memberInfo"></param>
        /// <returns></returns>
        public static bool HasAttribute<T>(this MemberInfo memberInfo)
        {
            return memberInfo.GetCustomAttributes(typeof(T), true).Any();
        }

        /// <summary>
        /// Check whether the <see cref="Type"/> has the specified attribute.
        /// </summary>
        /// <typeparam name="T">Attribute type.</typeparam>
        /// <param name="type"></param>
        /// <returns></returns>
        public static bool HasAttribute<T>(this Type type)
        {
            return type.GetCustomAttributes(typeof(T), true).Any();
        }

        /// <summary>
        /// Check whether the underlying type is nullable type.
        /// </summary>
        /// <param name="objectType"></param>
        /// <returns></returns>
        public static bool IsNullableType(this Type objectType)
        {
            return Nullable.GetUnderlyingType(objectType) != null;
        }

        /// <summary>
        /// Check whether the type is numeric type.
        /// </summary>
        /// <param name="objectType"></param>
        /// <returns></returns>
        public static bool IsNumericType(this Type objectType)
        {
            switch (Type.GetTypeCode(objectType))
            {
                case TypeCode.Byte:
                case TypeCode.SByte:
                case TypeCode.UInt16:
                case TypeCode.UInt32:
                case TypeCode.UInt64:
                case TypeCode.Int16:
                case TypeCode.Int32:
                case TypeCode.Int64:
                case TypeCode.Decimal:
                case TypeCode.Double:
                case TypeCode.Single:
                    return true;
                default:
                    return false;
            }
        }

        /// <summary>
        /// Gets the specified attribute or default from current <see cref="PropertyInfo"/>.
        /// </summary>
        /// <typeparam name="T">Attribute type.</typeparam>
        /// <param name="propertyInfo"></param>
        /// <returns></returns>
        public static T GetAttribute<T>(this PropertyInfo propertyInfo)
        {
            if (propertyInfo.HasAttribute<T>())
            {
                return (T)propertyInfo.GetCustomAttributes(typeof(T), true).FirstOrDefault();
            }

            return default;
        }

        /// <summary>
        /// Gets the specified attribute or default from current <see cref="MethodInfo"/>.
        /// </summary>
        /// <typeparam name="T">Attribute type.</typeparam>
        /// <param name="methodInfo"></param>
        /// <returns></returns>
        public static T GetAttribute<T>(this MethodInfo methodInfo)
        {
            if (methodInfo.HasAttribute<T>())
            {
                return (T)methodInfo.GetCustomAttributes(typeof(T), true).FirstOrDefault();
            }

            return default;
        }

        /// <summary>
        /// Gets the specified attribute or default from current <see cref="MemberInfo"/>.
        /// </summary>
        /// <typeparam name="T">Attribute type.</typeparam>
        /// <param name="memberInfo"></param>
        /// <returns></returns>
        public static T GetAttribute<T>(this MemberInfo memberInfo)
        {
            if (memberInfo.HasAttribute<T>())
            {
                return (T)memberInfo.GetCustomAttributes(typeof(T), true).FirstOrDefault();
            }

            return default;
        }

        /// <summary>
        /// Gets the specified attribute or default from current <see cref="Type"/>.
        /// </summary>
        /// <typeparam name="T">Attribute type.</typeparam>
        /// <param name="type"></param>
        /// <returns></returns>
        public static T GetAttribute<T>(this Type type)
        {
            if (type.HasAttribute<T>())
            {
                return (T)type.GetCustomAttributes(typeof(T), true).FirstOrDefault();
            }

            return default;
        }

        /// <summary>
        /// Returns the default value of type.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static object GetDefaultValue(this Type type)
        {
            var defaultExpression = Expression.Convert(Expression.Default(type), typeof(object));
            var expression = Expression.Lambda<Func<object>>(defaultExpression);

            return expression.Compile()();
        }

        /// <summary>
        /// Validates enum existing.
        /// </summary>
        /// <typeparam name="TEnum">Type of the enum.</typeparam>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsEnumExist<TEnum>(this TEnum value)
        {
            var enumType = typeof(TEnum);
            var enumValues = Enum.GetValues(enumType);
            foreach (var enumValue in enumValues)
            {
                if ((int)Enum.Parse(enumType, value.ToString()) == (int)enumValue)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Checks whether a type is a iterable type.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static bool IsIterableType(this Type type)
        {
            var originalSourceType = ReflectionHelpers.GetTypeByIgnoreTheNullable(type);
            bool isEnumerableType = originalSourceType.IsEnumerableType();
            bool isCollectionType = originalSourceType.IsCollectionType();
            bool isArray = originalSourceType.IsArray;

            return isEnumerableType || isCollectionType || isArray;
        }

        /// <summary>
        /// Checks whether a type is a collection or not.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static bool IsCollectionType(this Type type) => type.ImplementsGenericInterface(typeof(ICollection<>));

        /// <summary>
        /// Checks whether a type is a list or not.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static bool IsListType(this Type type) => typeof(IList).IsAssignableFrom(type);

        /// <summary>
        /// Checks whether a type is enumerable.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static bool IsEnumerableType(this Type type) => typeof(IEnumerable).IsAssignableFrom(type);

        /// <summary>
        /// Check whether a type is implement generic interface.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="interfaceType"></param>
        /// <returns></returns>
        public static bool ImplementsGenericInterface(this Type type, Type interfaceType) => type.GetGenericInterface(interfaceType) != null;

        /// <summary>
        /// Get generic interface of a type.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="genericInterface"></param>
        /// <returns></returns>
        public static Type GetGenericInterface(this Type type, Type genericInterface) =>
            type.IsGenericType(genericInterface) ? type : type.GetInterfaces().FirstOrDefault(t => t.IsGenericType(genericInterface));

        /// <summary>
        /// Checks whether a type is ga generic type.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="genericType"></param>
        /// <returns></returns>
        public static bool IsGenericType(this Type type, Type genericType) => type.IsGenericType && type.GetGenericTypeDefinition() == genericType;
    }
}