using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Definux.Utilities.Functions;

namespace Definux.Emeraude.Admin.Utilities
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

            var searchQueryArray = searchQuery.ToLower().Split(' ', ',', ';');

            Type entityType = typeof(TEntity);
            var entityProperties = entityType.GetProperties();
            var expressionsList = new List<Expression<Func<TEntity, bool>>>();
            foreach (var property in entityProperties)
            {
                Expression<Func<TEntity, bool>> currentExpression = x =>
                           x.GetType().GetProperty(property.Name).GetValue(x) != null &&
                           (x.GetType().GetProperty(property.Name).GetValue(x).ToString().ToLower().Contains(searchQuery.ToLower()) ||
                            searchQueryArray.Contains(x.GetType().GetProperty(property.Name).GetValue(x).ToString().ToLower()));

                expressionsList.Add(currentExpression);
            }

            var resultExpression = expressionsList.FirstOrDefault();
            for (int i = 1; i < expressionsList.Count; i++)
            {
                resultExpression = ExpressionFunctions.OrElse<TEntity>(resultExpression, expressionsList[i]);
            }

            return resultExpression;
        }

        /// <summary>
        /// Extract filter expression for entity by referenced entity property and its value.
        /// </summary>
        /// <typeparam name="TEntity">Target entity.</typeparam>
        /// <param name="foreignKeyProperty"></param>
        /// <param name="foreignKeyValue"></param>
        /// <returns></returns>
        public static Expression<Func<TEntity, bool>> BuildQueryExpressionByParentForeignKey<TEntity>(string foreignKeyProperty, string foreignKeyValue)
        {
            Expression<Func<TEntity, bool>> expression = x =>
                           x.GetType().GetProperty(foreignKeyProperty).GetValue(x) != null &&
                           x.GetType().GetProperty(foreignKeyProperty).GetValue(x).ToString() == foreignKeyValue;

            return expression;
        }
    }
}
