using Definux.Emeraude.Application.Common.Interfaces.Logging;
using Definux.Emeraude.Application.Common.Interfaces.Persistence;
using Definux.Emeraude.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Definux.Emeraude.Admin.Requests.ApplyImage
{
    public class ApplyImageCommandHandler<TEntity> : IRequestHandler<ApplyImageCommand<TEntity>, bool>
        where TEntity : class, IEntityWithImage, new()
    {
        private readonly IEmContext context;
        private readonly ILogger logger;

        public ApplyImageCommandHandler(IEmContext context, ILogger logger)
        {
            this.context = context;
            this.logger = logger;
        }

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
