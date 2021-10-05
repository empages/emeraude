using Definux.Emeraude.Domain.Entities;

namespace Definux.Emeraude.Admin.EmPages.Data.Requests
{
    /// <summary>
    /// Implementation of generic entity request.
    /// </summary>
    /// <typeparam name="TEntity">Target entity.</typeparam>
    public abstract class EmPageGenericEntityRequst<TEntity> : IEmPageGenericEntityRequest<TEntity>
        where TEntity : class, IEntity, new()
    {
    }
}
