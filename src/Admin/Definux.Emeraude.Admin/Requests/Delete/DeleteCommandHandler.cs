using AutoMapper;
using Definux.Emeraude.Admin.Utilities;
using Definux.Emeraude.Application.Common.Interfaces.Logging;
using Definux.Emeraude.Application.Common.Interfaces.Persistence;
using Definux.Emeraude.Domain.Entities;
using Definux.Utilities.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Definux.Emeraude.Admin.Requests.Delete
{
    public class DeleteCommandHandler<TEntity> : IDeleteCommandHandler<DeleteCommand<TEntity>, TEntity>
        where TEntity : class, IEntity, new()
    {
        private readonly IEmContext context;
        private readonly IMapper mapper;
        private readonly ILogger logger;

        public DeleteCommandHandler(IEmContext context, IMapper mapper, ILogger logger)
        {
            this.context = context;
            this.mapper = mapper;
            this.logger = logger;
        }

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
