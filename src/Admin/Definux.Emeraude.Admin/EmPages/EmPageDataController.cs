using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Definux.Emeraude.Admin.Controllers.Abstractions;
using Definux.Emeraude.Admin.Models;
using Definux.Emeraude.Admin.Requests.Fetch;
using Definux.Emeraude.Admin.Utilities;
using Definux.Emeraude.Domain.Entities;
using Definux.Emeraude.Essentials.Models;
using Microsoft.AspNetCore.Mvc;

namespace Definux.Emeraude.Admin.EmPages
{
    /// <summary>
    /// Admin API controller that implements <see cref="IEmPageDataController"/> and provides set of all required actions and functions for auto CRUD operations of EmPages.
    /// </summary>
    /// <typeparam name="TEntity">Entity from the domain model.</typeparam>
    /// <typeparam name="TModel">EmPage model for the selected entity.</typeparam>
    [Route("/api/_em/[controller]")]
    public abstract class EmPageDataController<TEntity, TModel> : AdminController, IEmPageDataController
        where TEntity : class, IEntity, new()
        where TModel : class, IEmPageModel, new()
    {
        /// <summary>
        /// Fetch action.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("")]
        public virtual async Task<IActionResult> Fetch(EntitiesFetchQueryRequest request)
        {
            request.OrderBy = this.InterceptOrderProperty(request.OrderBy);
            PaginatedList<TModel> entitiesResult = await this.FetchEntitiesAsync(request);
            var result = new TableViewDataRequestGenericResult<TModel>(entitiesResult);

            return this.Ok(result);
        }

        /// <summary>
        /// Method that return the instance of <see cref="IFetchQuery{TEntity,TRequestModel}"/> for current entity and view-model.
        /// </summary>
        /// <param name="fetchQuery"></param>
        /// <returns></returns>
        protected virtual IFetchQuery<TEntity, TModel> GetFetchQuery(EntitiesFetchQueryRequest fetchQuery)
        {
            return new FetchQuery<TEntity, TModel>
            {
                SearchQuery = fetchQuery.SearchQuery,
                Page = fetchQuery.Page,
                OrderBy = fetchQuery.OrderBy,
                OrderType = fetchQuery.OrderType,
            };
        }

        /// <summary>
        /// Fetch action executor.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        protected virtual async Task<PaginatedList<TModel>> FetchEntitiesAsync(EntitiesFetchQueryRequest request)
        {
            return await this.Mediator.Send(this.GetFetchQuery(request));
        }

        /// <summary>
        /// Return list of all order properties for current entity.
        /// </summary>
        /// <returns></returns>
        protected virtual List<string> GetOrderProperties()
        {
            return typeof(TEntity)
                .GetProperties()
                .Where(x => (DefaultValues.OrderTypes.Contains(x.PropertyType) || x.PropertyType.IsEnum) && x.GetSetMethod() != null)
                .Select(x => x.Name)
                .Where(x => x != nameof(IEntity.Id))
                .ToList();
        }

        private string InterceptOrderProperty(string property)
        {
            var allowedProperties = this.GetOrderProperties();
            return allowedProperties.Contains(property) ? property : null;
        }
    }
}