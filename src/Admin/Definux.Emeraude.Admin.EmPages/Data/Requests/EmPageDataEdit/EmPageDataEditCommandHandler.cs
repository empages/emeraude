using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Definux.Emeraude.Application.Logger;
using Definux.Emeraude.Application.Persistence;
using Definux.Emeraude.Domain.Entities;
using Definux.Utilities.Functions;
using Microsoft.EntityFrameworkCore;

namespace Definux.Emeraude.Admin.EmPages.Data.Requests.EmPageDataEdit
{
    /// <inheritdoc cref="IEmPageDataEditCommandHandler{TEditCommand,TEntity,TRequestModel}"/>
    public class EmPageDataEditCommandHandler<TEntity, TRequestModel> : IEmPageDataEditCommandHandler<EmPageDataEditCommand<TEntity, TRequestModel>, TEntity, TRequestModel>
        where TEntity : class, IEntity, new()
        where TRequestModel : class, new()
    {
        private readonly IEmContext context;
        private readonly IMapper mapper;
        private readonly IEmLogger logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmPageDataEditCommandHandler{TEntity,TRequestModel}"/> class.
        /// </summary>
        /// <param name="mapper"></param>
        /// <param name="logger"></param>
        /// <param name="logger"></param>
        public EmPageDataEditCommandHandler(IEmContext context, IMapper mapper, IEmLogger logger)
        {
            this.context = context;
            this.mapper = mapper;
            this.logger = logger;
        }

        /// <inheritdoc/>
        public async Task<Guid?> Handle(EmPageDataEditCommand<TEntity, TRequestModel> request, CancellationToken cancellationToken)
        {
            try
            {
                var dbSet = this.context.Set<TEntity>();
                var currentEntity = await dbSet.FirstOrDefaultAsync(x => x.Id == request.EntityId, cancellationToken);

                if (currentEntity != null)
                {
                    this.mapper.Map(request.Model, currentEntity);

                    currentEntity.Id = request.EntityId;
                    dbSet.Update(currentEntity);
                    await this.context.SaveChangesAsync(cancellationToken);

                    return request.EntityId;
                }

                return null;
            }
            catch (Exception ex)
            {
                await this.logger.LogErrorAsync(ex, nameof(EmPageDataEditCommandHandler<TEntity, TRequestModel>));
                return null;
            }
        }
    }
}
