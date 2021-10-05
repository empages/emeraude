using Definux.Emeraude.Domain.Entities;

namespace Definux.Emeraude.Admin.EmPages.Data.Requests
{
    /// <summary>
    /// Implementation of generic new entity request.
    /// </summary>
    /// <typeparam name="TEntity">Target entity.</typeparam>
    public abstract class EmPageGenericNewEntityRequest<TEntity> : IEmPageGenericNewEntityRequest<TEntity>
        where TEntity : class, IEntity, new()
    {
    }
}
