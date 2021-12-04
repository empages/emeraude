using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Emeraude.Application.Admin.EmPages.Schema;
using Emeraude.Contracts;
using Emeraude.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Emeraude.Application.Admin.EmPages.Data.Requests.EmPageDataDelete;

/// <inheritdoc cref="IEmPageDataDeleteCommandHandler{TDeleteCommand,TEntity, TModel}"/>
public class EmPageDataDeleteCommandHandler<TEntity, TModel> : IEmPageDataDeleteCommandHandler<EmPageDataDeleteCommand<TEntity, TModel>, TEntity, TModel>
    where TEntity : class, IEntity, new()
    where TModel : class, IEmPageModel, new()
{
    private readonly IEmContext context;
    private readonly IMapper mapper;
    private readonly ILogger<EmPageDataDeleteCommandHandler<TEntity, TModel>> logger;

    /// <summary>
    /// Initializes a new instance of the <see cref="EmPageDataDeleteCommandHandler{TEntity, TModel}"/> class.
    /// </summary>
    /// <param name="context"></param>
    /// <param name="mapper"></param>
    /// <param name="logger"></param>
    public EmPageDataDeleteCommandHandler(IEmContext context, IMapper mapper, ILogger<EmPageDataDeleteCommandHandler<TEntity, TModel>> logger)
    {
        this.context = context;
        this.mapper = mapper;
        this.logger = logger;
    }

    /// <inheritdoc/>
    public async Task<bool> Handle(EmPageDataDeleteCommand<TEntity, TModel> request, CancellationToken cancellationToken)
    {
        try
        {
            var dbSet = this.context.Set<TEntity>();
            var currentEntity = await dbSet.FirstOrDefaultAsync(x => x.Id == request.EntityId, cancellationToken);

            if (currentEntity != null)
            {
                dbSet.Remove(currentEntity);
                await this.context.SaveChangesAsync(cancellationToken);

                return true;
            }

            return false;
        }
        catch (Exception ex)
        {
            this.logger.LogError(ex, "EmPage delete command fails");
            return false;
        }
    }
}