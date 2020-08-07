using Definux.Utilities.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Definux.Emeraude.Admin.Utilities
{
    public static class ExpressionBuilders
    {
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

        public static Expression<Func<TEntity, bool>> BuildQueryExpressionByParentForeignKey<TEntity>(string foreignKeyProperty, string foreignKeyValue)
        {
            Expression<Func<TEntity, bool>> expression = x =>
                           x.GetType().GetProperty(foreignKeyProperty).GetValue(x) != null &&
                           x.GetType().GetProperty(foreignKeyProperty).GetValue(x).ToString() == foreignKeyValue;

            return expression;
        }
    }
}
