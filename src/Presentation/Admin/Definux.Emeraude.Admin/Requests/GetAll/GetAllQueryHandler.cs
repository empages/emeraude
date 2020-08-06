using AutoMapper;
using AutoMapper.QueryableExtensions;
using Definux.Emeraude.Admin.Utilities;
using Definux.Emeraude.Application.Common.Interfaces.Logging;
using Definux.Emeraude.Application.Common.Interfaces.Persistence;
using Definux.Emeraude.Domain.Entities;
using Definux.Utilities.Functions;
using Definux.Utilities.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace Definux.Emeraude.Admin.Requests.GetAll
{
    public class GetAllQueryHandler<TEntity, TRequestModel> : IGetAllQueryHandler<GetAllQuery<TEntity, TRequestModel>, TEntity, TRequestModel>
        where TEntity : class, IEntity, new()
        where TRequestModel : class, new()
    {
        private readonly IEmContext context;
        private readonly IMapper mapper;
        private readonly ILogger logger;

        public GetAllQueryHandler(IEmContext context, IMapper mapper, ILogger logger)
        {
            this.context = context;
            this.mapper = mapper;
            this.logger = logger;
        }

        public Expression<Func<TEntity, bool>> GetSearchQueryExpression(string searchQuery)
        {
            return ExpressionBuilders.BuildQueryExpressionBySearchQuery<TEntity>(searchQuery);
        }

        public async Task<PaginatedList<TRequestModel>> Handle(GetAllQuery<TEntity, TRequestModel> request, CancellationToken cancellationToken)
        {
            PaginatedList<TRequestModel> result = new PaginatedList<TRequestModel>();

            try
            {
                var requestExpression = BuildRequestExpression(request);

                result.AllItemsCount = this.context
                        .Set<TEntity>()
                        .AsQueryable()
                        .Where(requestExpression.Compile())
                        .Count();

                result.CurrentPage = request.Page;
                result.PageSize = request.PageSize;

                IEnumerable<TRequestModel> entities = this.context
                        .Set<TEntity>()
                        .AsQueryable()
                        .Where(requestExpression.Compile())
                        .Skip(result.StartRow)
                        .Take(request.PageSize)
                        .AsQueryable()
                        .ProjectTo<TRequestModel>(this.mapper.ConfigurationProvider)
                        .ToList();

                result.Items = entities;
            }
            catch (Exception ex)
            {
                await this.logger.LogErrorAsync(ex, nameof(GetAllQueryHandler<TEntity, TRequestModel>));
            }

            return result;
        }

        private Expression<Func<TEntity, bool>> BuildRequestExpression(GetAllQuery<TEntity, TRequestModel> request)
        {
            var expressionList = new List<Expression<Func<TEntity, bool>>>();

            var queryExpressionBySearchQuery = !string.IsNullOrEmpty(request.SearchQuery) ? ExpressionBuilders.BuildQueryExpressionBySearchQuery<TEntity>(request.SearchQuery) : null;
            if (queryExpressionBySearchQuery != null)
            {
                expressionList.Add(queryExpressionBySearchQuery);
            }

            var queryExpressionByParentForeignKey = request.ValidateParent ? ExpressionBuilders.BuildQueryExpressionByParentForeignKey<TEntity>(request.ForeignKeyProperty, request.ForeignKeyValue) : null;
            if (queryExpressionByParentForeignKey != null)
            {
                expressionList.Add(queryExpressionByParentForeignKey);
            }

            Expression<Func<TEntity, bool>> requestExpression = x => true;
            if (expressionList.Count > 0)
            {
                foreach (var expression in expressionList)
                {
                    requestExpression = ExpressionFunctions.AndAlso(requestExpression, expression);
                }
            }

            return requestExpression;
        }
    }
}
