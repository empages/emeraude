﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Definux.Emeraude.Admin.Utilities;
using Definux.Emeraude.Application.Logger;
using Definux.Emeraude.Application.Persistence;
using Definux.Emeraude.Domain.Entities;
using Definux.Utilities.Functions;
using Definux.Utilities.Objects;

namespace Definux.Emeraude.Admin.Requests.GetAll
{
    /// <inheritdoc/>
    public class GetAllQueryHandler<TEntity, TRequestModel> : IGetAllQueryHandler<GetAllQuery<TEntity, TRequestModel>, TEntity, TRequestModel>
        where TEntity : class, IEntity, new()
        where TRequestModel : class, new()
    {
        private readonly IEmContext context;
        private readonly IMapper mapper;
        private readonly IEmLogger logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAllQueryHandler{TEntity, TRequestModel}"/> class.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="mapper"></param>
        /// <param name="logger"></param>
        public GetAllQueryHandler(IEmContext context, IMapper mapper, IEmLogger logger)
        {
            this.context = context;
            this.mapper = mapper;
            this.logger = logger;
        }

        /// <inheritdoc/>
        public async Task<PaginatedList<TRequestModel>> Handle(GetAllQuery<TEntity, TRequestModel> request, CancellationToken cancellationToken)
        {
            PaginatedList<TRequestModel> result = new PaginatedList<TRequestModel>();

            try
            {
                var requestExpression = this.BuildRequestExpression(request);

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
