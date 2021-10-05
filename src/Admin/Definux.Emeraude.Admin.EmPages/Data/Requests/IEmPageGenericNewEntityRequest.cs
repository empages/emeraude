using System;
using Definux.Emeraude.Domain.Entities;

namespace Definux.Emeraude.Admin.EmPages.Data.Requests
{
    /// <summary>
    /// Definition of generic new entity request.
    /// </summary>
    /// <typeparam name="TEntity">Target entity.</typeparam>
    public interface IEmPageGenericNewEntityRequest<TEntity>
        where TEntity : class, IEntity, new()
    {
    }
}
