using Definux.Emeraude.Application.Common.Interfaces.Logging;
using Definux.Emeraude.Application.Common.Interfaces.Persistence;
using Definux.Emeraude.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Definux.Emeraude.Admin.Requests.GetEntityImage
{
    public class GetEntityImageQueryHandler<TEntity> : IRequestHandler<GetEntityImageQuery<TEntity>, string>
        where TEntity : class, IEntityWithImage, new()
    {
        private readonly IEmContext context;
        private readonly ILogger logger;

        public GetEntityImageQueryHandler(IEmContext context, ILogger logger)
        {
            this.context = context;
            this.logger = logger;
        }

        public async Task<string> Handle(GetEntityImageQuery<TEntity> request, CancellationToken cancellationToken)
        {
            try
            {
                return await this.context
                    .Set<TEntity>()
                    .AsQueryable()
                    .Where(x => x.Id == request.EntityId)
                    .Select(x => x.ImageUrl)
                    .FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                await this.logger.LogErrorAsync(ex, nameof(GetEntityImageQuery<TEntity>));
                return null;
            }
        }
    }
}
