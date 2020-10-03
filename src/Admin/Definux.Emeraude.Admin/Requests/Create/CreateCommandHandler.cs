using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Definux.Emeraude.Application.Common.Interfaces.Logging;
using Definux.Emeraude.Application.Common.Interfaces.Persistence;
using Definux.Emeraude.Domain.Entities;

namespace Definux.Emeraude.Admin.Requests.Create
{
    /// <inheritdoc cref="ICreateCommandHandler{TCreateCommand, TEntity, TRequestModel}"/>
    public class CreateCommandHandler<TEntity, TRequestModel> : ICreateCommandHandler<CreateCommand<TEntity, TRequestModel>, TEntity, TRequestModel>
        where TEntity : class, IEntity, new()
        where TRequestModel : class, new()
    {
        private readonly IEmContext context;
        private readonly IMapper mapper;
        private readonly ILogger logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCommandHandler{TEntity, TRequestModel}"/> class.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="mapper"></param>
        /// <param name="logger"></param>
        public CreateCommandHandler(IEmContext context, IMapper mapper, ILogger logger)
        {
            this.context = context;
            this.mapper = mapper;
            this.logger = logger;
        }

        /// <inheritdoc/>
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
