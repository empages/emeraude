using Emeraude.Application.Admin.EmPages.Schema;
using Emeraude.Contracts;

namespace Emeraude.Application.Admin.EmPages.Data.Requests;

/// <summary>
/// Contract of EmPage entity mutational request.
/// </summary>
/// <typeparam name="TEntity">Target entity.</typeparam>
/// <typeparam name="TModel">EmPage model.</typeparam>
public interface IEmPageEntityMutationalRequest<TEntity, TModel> : IEmPageEntityRequest<TEntity, TModel>
    where TEntity : class, IEntity, new()
    where TModel : class, IEmPageModel, new()
{
    /// <summary>
    /// Model of the request.
    /// </summary>
    public TModel Model { get; set; }
}