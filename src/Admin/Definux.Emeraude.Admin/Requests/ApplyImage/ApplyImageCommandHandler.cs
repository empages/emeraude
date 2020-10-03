using System;
using System.Threading;
using System.Threading.Tasks;
using Definux.Emeraude.Application.Common.Interfaces.Logging;
using Definux.Emeraude.Application.Common.Interfaces.Persistence;
using Definux.Emeraude.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Definux.Emeraude.Admin.Requests.ApplyImage
{
    /// <inheritdoc cref="IRequestHandler{TRequest, TResponse}"/>
    public class ApplyImageCommandHandler<TEntity> : IRequestHandler<ApplyImageCommand<TEntity>, bool>
        where TEntity : class, IEntityWithImage, new()
    {
        private readonly IEmContext context;
        private readonly ILogger logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplyImageCommandHandler{TEntity}"/> class.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="logger"></param>
        public ApplyImageCommandHandler(IEmContext context, ILogger logger)
        {
            this.context = context;
            this.logger = logger;
        }

        /// <inheritdoc/>
        public async Task<bool> Handle(ApplyImageCommand<TEntity> request, CancellationToken cancellationToken)
        {
            try
            {
                var entity = await this.context
                    .Set<TEntity>()
                    .AsQueryable()
                    .FirstOrDefaultAsync(x => x.Id == request.EntityId);

                if (entity != null)
                {
                    entity.ImageUrl = request.ImageUrl;
                    this.context.Set<TEntity>().Update(entity);
                    await this.context.SaveChangesAsync();

                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                await this.logger.LogErrorAsync(ex, nameof(ApplyImageCommandHandler<TEntity>));
                return false;
            }
        }
    }
}
