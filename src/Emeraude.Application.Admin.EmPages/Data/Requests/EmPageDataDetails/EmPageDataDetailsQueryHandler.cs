using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Emeraude.Application.Admin.EmPages.Schema;
using Emeraude.Application.Admin.EmPages.Services;
using Emeraude.Contracts;
using Emeraude.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Emeraude.Application.Admin.EmPages.Data.Requests.EmPageDataDetails;

/// <inheritdoc cref="IEmPageDataDetailsQueryHandler{TDetailsQuery,TEntity,TModel}"/>
public class EmPageDataDetailsQueryHandler<TEntity, TModel> : IEmPageDataDetailsQueryHandler<EmPageDataDetailsQuery<TEntity, TModel>, TEntity, TModel>
    where TEntity : class, IEntity, new()
    where TModel : class, IEmPageModel, new()
{
    private readonly IEmContext context;
    private readonly IMapper mapper;
    private readonly ILogger<EmPageDataDetailsQueryHandler<TEntity, TModel>> logger;

    /// <summary>
    /// Initializes a new instance of the <see cref="EmPageDataDetailsQueryHandler{TEntity,TModel}"/> class.
    /// </summary>
    /// <param name="context"></param>
    /// <param name="mapper"></param>
    /// <param name="logger"></param>
    public EmPageDataDetailsQueryHandler(
        IEmContext context,
        IMapper mapper,
        ILogger<EmPageDataDetailsQueryHandler<TEntity, TModel>> logger)
    {
        this.context = context;
        this.mapper = mapper;
        this.logger = logger;
    }

    /// <inheritdoc/>
    public async Task<TModel> Handle(EmPageDataDetailsQuery<TEntity, TModel> request, CancellationToken cancellationToken)
    {
        try
        {
            var entityQuery = this.context
                .Set<TEntity>()
                .Where(x => x.Id == request.EntityId);

            if (request.QueryInterceptor != null)
            {
                entityQuery = request.QueryInterceptor(request, entityQuery);
            }

            var entity = await entityQuery.FirstOrDefaultAsync(x => x.Id == request.EntityId, cancellationToken);

            return this.mapper.Map<TModel>(entity);
        }
        catch (Exception ex)
        {
            this.logger.LogError(ex, "EmPage details query fails");
            return null;
        }
    }
}