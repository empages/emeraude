using Emeraude.Application.Admin.EmPages.Schema;
using Emeraude.Contracts;

namespace Emeraude.Application.Admin.EmPages.Data.Requests
{
    /// <summary>
    /// Contract of EmPage entity request.
    /// </summary>
    /// <typeparam name="TEntity">Target entity.</typeparam>
    /// <typeparam name="TModel">EmPage model.</typeparam>
    public interface IEmPageEntityRequest<TEntity, TModel> : IEmPageRequest<TModel>
        where TEntity : class, IEntity, new()
        where TModel : class, IEmPageModel, new()
    {
    }
}
