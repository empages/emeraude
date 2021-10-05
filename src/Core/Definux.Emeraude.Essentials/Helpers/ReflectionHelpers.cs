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
        /// <typeparam name="T">Type of the object.</typeparam>
        /// <returns></returns>
        public static MemberInfo GetCorrectPropertyMember<T>(Expression<Func<T, object>> expression)
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