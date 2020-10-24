using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Definux.Emeraude.Admin.Utilities;
using Definux.Emeraude.Application.Logger;
using Definux.Emeraude.Application.Persistence;
using Definux.Emeraude.Domain.Entities;
using Definux.Utilities.Functions;

namespace Definux.Emeraude.Admin.Requests.Delete
{
    /// <inheritdoc cref="IDeleteCommandHandler{TDeleteCommand, TEntity}"/>
    public class DeleteCommandHandler<TEntity> : IDeleteCommandHandler<DeleteCommand<TEntity>, TEntity>
        where TEntity : class, IEntity, new()
    {
        private readonly IEmContext context;
        private readonly IMapper mapper;
        private readonly IEmLogger logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteCommandHandler{TEntity}"/> class.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="mapper"></param>
        /// <param name="logger"></param>
        public DeleteCommandHandler(IEmContext context, IMapper mapper, IEmLogger logger)
        {
            this.context = context;
            this.mapper = mapper;
            this.logger = logger;
        }

        /// <inheritdoc/>
        public async Task<bool> Handle(DeleteCommand<TEntity> request, CancellationToken cancellationToken)
        {
            try
            {
                var dbSet = this.context.Set<TEntity>();
                var requestExpression = request.ValidateParent ? ExpressionBuilders.BuildQueryExpressionByParentForeignKey<TEntity>(request.ForeignKeyProperty, request.ForeignKeyValue) : x => true;
                var currentEntity = dbSet
                    .AsQueryable()
                    .Where(ExpressionFunctions.AndAlso(requestExpression, x => x.Id == request.EntityId).Compile())
                    .FirstOrDefault();

                if (currentEntity != null)
                {
                    dbSet.Remove(currentEntity);
                    await this.context.SaveChangesAsync();

                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                await this.logger.LogErrorAsync(ex, nameof(DeleteCommandHandler<TEntity>));
                return false;
            }
        }
    }
}
