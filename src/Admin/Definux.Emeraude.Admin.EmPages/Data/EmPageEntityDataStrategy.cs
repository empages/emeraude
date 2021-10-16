using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using Definux.Emeraude.Admin.EmPages.Data.Requests;
using Definux.Emeraude.Admin.EmPages.Data.Requests.EmPageDataCreate;
using Definux.Emeraude.Admin.EmPages.Data.Requests.EmPageDataDetails;
using Definux.Emeraude.Admin.EmPages.Data.Requests.EmPageDataFetch;
using Definux.Emeraude.Admin.EmPages.Data.Requests.EmPageDataRawModel;
using Definux.Emeraude.Admin.EmPages.Exceptions;
using Definux.Emeraude.Admin.EmPages.Schema;
using Definux.Emeraude.Domain.Entities;
using Definux.Emeraude.Essentials.Helpers;
using Definux.Utilities.Functions;

namespace Definux.Emeraude.Admin.EmPages.Data
{
    /// <summary>
    /// EmPage data strategy implementation for using domain entities.
    /// </summary>
    /// <typeparam name="TEntity">Domain entity.</typeparam>
    /// <typeparam name="TModel">EmPage model.</typeparam>
    public abstract class EmPageEntityDataStrategy<TEntity, TModel> : IEmPageDataStrategy<TModel>, IEmPageEntityDataStrategy
        where TEntity : class, IEntity, new()
        where TModel : class, IEmPageModel, new()
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmPageEntityDataStrategy{TEntity, TModel}"/> class.
        /// </summary>
        protected EmPageEntityDataStrategy()
        {
            this.CustomFilterExpressionsBuilders = new Dictionary<PropertyInfo, Func<object, Expression<Func<TEntity, bool>>>>();
        }

        /// <summary>
        /// Dictionary that contains filter expressions for model properties.
        /// </summary>
        protected IDictionary<PropertyInfo, Func<object, Expression<Func<TEntity, bool>>>> CustomFilterExpressionsBuilders { get; set; }

        /// <inheritdoc/>
        public IEmPageRequest<TModel> BuildRawModelQuery(EmPageDataFilter filter)
        {
            var filterExpression = this.BuildFilterExpression(filter);
            return new EmPageDataRawModelQuery<TEntity, TModel>(filterExpression);
        }

        /// <inheritdoc/>
        public virtual IEmPageRequest<TModel> BuildRawModelQuery(string modelId)
        {
            Guid.TryParse(modelId, out var entityId);
            return new EmPageDataRawModelQuery<TEntity, TModel>(entityId);
        }

        /// <inheritdoc/>
        public virtual IEmPageRequest<TModel> BuildFetchQuery(EmPageDataFetchQueryBody body)
        {
            return new EmPageDataFetchQuery<TEntity, TModel>
            {
                SearchQuery = body.SearchQuery,
                Page = body.Page,
                OrderBy = body.OrderBy,
                OrderType = body.OrderType,
                FilterExpression = this.BuildFilterExpression(body.Filter),
            };
        }

        /// <inheritdoc/>
        public virtual IEmPageRequest<TModel> BuildDetailsQuery(string modelId)
        {
            Guid.TryParse(modelId, out var entityId);
            return new EmPageDataDetailsQuery<TEntity, TModel>(entityId);
        }

        /// <inheritdoc/>
        public virtual IEmPageRequest<TModel> BuildCreateCommand(TModel model)
        {
            return new EmPageDataCreateCommand<TEntity, TModel>(model);
        }

        /// <summary>
        /// Register custom filter expression for manual filtration.
        /// </summary>
        /// <param name="property"></param>
        /// <param name="expressionFunction"></param>
        protected void AddCustomFilterExpression(Expression<Func<TModel, object>> property, Func<object, Expression<Func<TEntity, bool>>> expressionFunction)
        {
            var propertyInfo = ReflectionHelpers.GetCorrectPropertyMember(property) as PropertyInfo;
            this.CustomFilterExpressionsBuilders.Add(propertyInfo, expressionFunction);
        }

        /// <summary>
        /// Builds filter expression from specified filter and defined custom filter expression filters.
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        protected Expression<Func<TEntity, bool>> BuildFilterExpression(EmPageDataFilter filter)
        {
            if (filter == null)
            {
                return null;
            }

            Expression<Func<TEntity, bool>> resultExpression = x => true;
            foreach (var (property, value) in filter)
            {
                if (!this.CustomFilterExpressionsBuilders.ContainsKey(property))
                {
                    throw new EmPageMissingConfigurationException($"There is not defined custom filter expression for property info of '{property.Name}' of '{this.GetType().Name}'");
                }

                var currentFilterExpression = this.CustomFilterExpressionsBuilders[property];
                resultExpression = ExpressionFunctions.AndAlso(resultExpression, currentFilterExpression(value));
            }

            return resultExpression;
        }
    }
}