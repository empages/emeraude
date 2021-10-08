using Definux.Emeraude.Admin.EmPages.Schema;
using Definux.Emeraude.Domain.Entities;
using MediatR;

namespace Definux.Emeraude.Admin.EmPages.Data.Requests.EmPageDataDelete
{
    /// <inheritdoc/>
    public interface IEmPageDataDeleteCommandHandler<in TDeleteCommand, TEntity, TModel> : IRequestHandler<TDeleteCommand, bool>
        where TEntity : class, IEntity, new()
        where TModel : class, IEmPageModel, new()
        where TDeleteCommand : IEmPageDataDeleteCommand<TEntity, TModel>
    {
    }
}
