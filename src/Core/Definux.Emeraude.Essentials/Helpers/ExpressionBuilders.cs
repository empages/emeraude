using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Definux.Emeraude.Resources;
using Microsoft.EntityFrameworkCore;

namespace Definux.Emeraude.Essentials.Helpers
{
    /// <summary>
    /// Expression builders that helps for extraction expressions from simple arguments.
    /// </summary>
    public static class ExpressionBuilders
    {
        /// <summary>
        /// Extract filter expression for entity by search string.
        /// </summary>
        /// <typeparam name="TEntity">Target entity.</typeparam>
        /// <param name="searchQuery"></param>
        /// <returns></returns>
        public static Expression<Func<TEntity, bool>> BuildQueryExpressionBySearchQuery<TEntity>(string searchQuery)
        {
            if (!string.IsNullOrWhiteSpace(searchQuery))
            {
                searchQuery = searchQuery.Trim();
            }

            var allowedTypes = DefaultValues.OrderTypes;
            Type entityType = typeof(TEntity);
            var searchingProperties = entityType
                .GetProperties()
                .Where(x => allowedTypes.Contains(x.PropertyType) && x.GetSetMethod() != null)
                .Select(x => x.Name)
                .ToList();

            searchQuery = searchQuery?.ToLower() ?? string.Empty;
            if (string.IsNullOrEmpty(searchQuery))
            {
                return x => true;
            }

            var expressionsList = new List<Expression<Func<TEntity, bool>>>();
            foreach (var searchingPropertyName in searchingProperties)
            {
                var currentExpression = Search<TEntity>(searchingPropertyName, searchQuery);
                expressionsList.Add(currentExpression);
            }

            var resultExpression = expressionsList.FirstOrDefault();
            for (int i = 1; i < expressionsList.Count; i++)
            {
                resultExpression = OrElse<TEntity>(resultExpression, expressionsList[i]);
            }

            return resultExpression;
        }

        /// <summary>
        /// Build lambda expression from entityType and propertyName.
        /// </summary>
        /// <param name="propertyName"></param>
        /// <typeparam name="TEntity">Target entity.</typeparam>
        /// <returns></returns>
        public static Expression<Func<TEntity, object>> BuildLambdaExpression<TEntity>(string propertyName)
        {
            var parameter = Expression.Parameter(typeof(TEntity));
            var property = Expression.Property(parameter, propertyName);
            var propertyAsObject = Expression.Convert(property, typeof(object));

            return Expression.Lambda<Func<TEntity, object>>(propertyAsObject, parameter);
        }

        /// <summary>
        /// Sorts elements of a sequence in order according to the specified property name.
        /// </summary>
        /// <param name="queryable"></param>
        /// <param name="propertyName"></param>
        /// <param name="fallbackPropertyName"></param>
        /// <param name="orderType"></param>
        /// <typeparam name="TEntity">Target entity.</typeparam>
        /// <returns></returns>
        public static IOrderedQueryable<TEntity> OrderByProperty<TEntity>(
            this IQueryable<TEntity> queryable,
            string propertyName,
            string fallbackPropertyName,
            OrderType orderType = OrderType.Unspecified)
        {
            var propertyExists = typeof(TEntity).GetProperties().Any(x => x.Name == propertyName);
            if (!propertyExists)
            {
                return queryable.OrderBy(BuildLambdaExpression<TEntity>(fallbackPropertyName));
            }

            if (orderType == OrderType.Unspecified || orderType == OrderType.Ascending)
            {
                return queryable.OrderBy(BuildLambdaExpression<TEntity>(propertyName));
            }
            else
            {
                return queryable.OrderByDescending(BuildLambdaExpression<TEntity>(propertyName));
            }
        }

        /// <summary>
        /// Return expression from property of the target type and search query.
        /// </summary>
        /// <param name="propertyName"></param>
        /// <param name="searchQuery"></param>
        /// <typeparam name="T">Target type.</typeparam>
        /// <returns></returns>
        public static Expression<Func<T, bool>> Search<T>(string propertyName, string searchQuery)
        {
            if (string.IsNullOrEmpty(propertyName) || string.IsNullOrEmpty(searchQuery))
            {
                return x => true;
            }

            var property = typeof(T).GetProperty(propertyName);
            if (property is null)
            {
                return x => true;
            }

            searchQuery = $"%{searchQuery}%";
            var itemParameter = Expression.Parameter(typeof(T), "item");

            var functions = Expression.Property(null, typeof(EF).GetProperty(nameof(EF.Functions)));
            var like = typeof(DbFunctionsExtensions).GetMethod(nameof(DbFunctionsExtensions.Like), new Type[] { functions.Type, typeof(string), typeof(string) });

            Expression expressionProperty = Expression.Property(itemParameter, property.Name);

            if (property.PropertyType != typeof(string))
            {
                expressionProperty = Expression.Call(expressionProperty, typeof(object).GetMethod(nameof(object.ToString), new Type[0]));
            }

            expressionProperty = Expression.Call(expressionProperty, typeof(string).GetMethod(nameof(string.ToLower), new Type[0]));

            var selector = Expression.Call(
                null,
                like,
                functions,
                expressionProperty,
                Expression.Constant(searchQuery));

            return Expression.Lambda<Func<T, bool>>(selector, itemParameter);
        }

        /// <summary>
        /// Creates an expressions with OR conditional operation.
        /// </summary>
        /// <typeparam name="T">Type of the entity for expression.</typeparam>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static Expression<Func<T, bool>> OrElse<T>(Expression<Func<T, bool>> left, Expression<Func<T, bool>> right)
        {
            Expression<Func<T, bool>> combined = Expression.Lambda<Func<T, bool>>(
                Expression.OrElse(
                    left.Body,
                    new ExpressionParameterReplacer(right.Parameters, left.Parameters).Visit(right.Body)), left.Parameters);

            return combined;
        }

        /// <summary>
        /// Creates an expressions with AND conditional operation.
        /// </summary>
        /// <typeparam name="T">Type of the entity for expression.</typeparam>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static Expression<Func<T, bool>> AndAlso<T>(Expression<Func<T, bool>> left, Expression<Func<T, bool>> right)
        {
            Expression<Func<T, bool>> combined = Expression.Lambda<Func<T, bool>>(
                Expression.AndAlso(
                    left.Body,
                    new ExpressionParameterReplacer(right.Parameters, left.Parameters).Visit(right.Body)), left.Parameters);

            return combined;
        }
    }
}
