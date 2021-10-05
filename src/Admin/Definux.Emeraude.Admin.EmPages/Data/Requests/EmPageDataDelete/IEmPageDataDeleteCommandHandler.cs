using Definux.Emeraude.Domain.Entities;
using MediatR;

namespace Definux.Emeraude.Admin.EmPages.Data.Requests.EmPageDataDelete
{
    /// <inheritdoc/>
    public interface IEmPageDataDeleteCommandHandler<TDeleteCommand, TEntity> : IRequestHandler<TDeleteCommand, bool>
        where TEntity : class, IEntity, new()
        where TDeleteCommand : IEmPageDataDeleteCommand<TEntity>
    {
    }
}
