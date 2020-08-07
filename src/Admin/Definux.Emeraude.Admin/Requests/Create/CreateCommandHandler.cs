using AutoMapper;
using Definux.Emeraude.Application.Common.Interfaces.Logging;
using Definux.Emeraude.Application.Common.Interfaces.Persistence;
using Definux.Emeraude.Domain.Entities;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Definux.Emeraude.Admin.Requests.Create
{
    public class CreateCommandHandler<TEntity, TRequestModel> : ICreateCommandHandler<CreateCommand<TEntity, TRequestModel>, TEntity, TRequestModel>
        where TEntity : class, IEntity, new()
        where TRequestModel : class, new()
    {
        private readonly IEmContext context;
        private readonly IMapper mapper;
        private readonly ILogger logger;

        public CreateCommandHandler(IEmContext context, IMapper mapper, ILogger logger)
        {
            this.context = context;
            this.mapper = mapper;
            this.logger = logger;
        }

        public async Task<Guid?> Handle(CreateCommand<TEntity, TRequestModel> request, CancellationToken cancellationToken)
        {
            try
            {
                var mappedEntity = this.mapper.Map<TEntity>(request.Model);
                if (request.ValidateParent)
                {
                    mappedEntity
                        .GetType()
                        .GetProperty(request.ForeignKeyProperty)
                        .SetValue(mappedEntity, Guid.Parse(request.ForeignKeyValue));
                }

                this.context.Set<TEntity>().Add(mappedEntity);
                await this.context.SaveChangesAsync();

                return mappedEntity.Id;
            }
            catch (Exception ex)
            {
                await this.logger.LogErrorAsync(ex, nameof(CreateCommandHandler<TEntity, TRequestModel>));
                return null;
            }
        }
    }
}
