using Emeraude.Application.Admin.EmPages.Schema;
using Emeraude.Contracts;
using MediatR;

namespace Emeraude.Application.Admin.EmPages.Data.Requests.EmPageDataDelete
{
    /// <inheritdoc/>
    public interface IEmPageDataDeleteCommandHandler<in TDeleteCommand, TEntity, TModel> : IRequestHandler<TDeleteCommand, bool>
        where TEntity : class, IEntity, new()
        where TModel : class, IEmPageModel, new()
        where TDeleteCommand : IEmPageDataDeleteCommand<TEntity, TModel>
    {
    }
}
