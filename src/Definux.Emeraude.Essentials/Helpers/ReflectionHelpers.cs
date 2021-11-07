using System;
using System.Linq.Expressions;
using System.Reflection;

namespace Definux.Emeraude.Essentials.Helpers
{
    /// <summary>
    /// Reflection functions.
    /// </summary>
    public static class ReflectionHelpers
    {
        /// <summary>
        /// Gets property member info.
        /// </summary>
        /// <param name="expression"></param>
        /// <typeparam name="TProperty">Type of the object.</typeparam>
        /// <returns></returns>
        public static MemberInfo GetCorrectPropertyMember<TProperty>(Expression<Func<TProperty, object>> expression)
        {
            return GetCorrectPropertyMember<TProperty, object>(expression);
        }

        /// <summary>
        /// Gets type by ignoring the nullable type.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static Type GetTypeByIgnoreTheNullable(Type type)
        {
            return Nullable.GetUnderlyingType(type) != null ? Nullable.GetUnderlyingType(type) : type;
        }

        /// <summary>
        /// Gets property member info.
        /// </summary>
        /// <param name="expression"></param>
        /// <typeparam name="TProperty">Type of the object.</typeparam>
        /// <typeparam name="TResult">Type of the property.</typeparam>
        /// <returns></returns>
        public static MemberInfo GetCorrectPropertyMember<TProperty, TResult>(Expression<Func<TProperty, TResult>> expression)
        {
            if (expression.Body is MemberExpression memberExpression)
            {
                return memberExpression.Member;
            }

            var operand = ((UnaryExpression)expression.Body).Operand;
            return ((MemberExpression)operand).Member;
        }
    }
}