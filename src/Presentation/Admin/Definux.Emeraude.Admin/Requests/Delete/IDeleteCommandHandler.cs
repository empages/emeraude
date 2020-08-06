using Definux.Emeraude.Domain.Entities;
using MediatR;

namespace Definux.Emeraude.Admin.Requests.Delete
{
    public interface IDeleteCommandHandler<TDeleteCommand, TEntity> : IRequestHandler<TDeleteCommand, bool>
        where TEntity : class, IEntity, new()
        where TDeleteCommand : IDeleteCommand<TEntity>
    {
    }
}
