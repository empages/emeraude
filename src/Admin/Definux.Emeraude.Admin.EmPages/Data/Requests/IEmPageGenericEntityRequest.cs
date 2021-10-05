using System;
using System.Linq.Expressions;
using Definux.Emeraude.Domain.Entities;

namespace Definux.Emeraude.Admin.EmPages.Data.Requests
{
    /// <summary>
    /// Definition of generic entity request.
    /// </summary>
    /// <typeparam name="TEntity">Target entity.</typeparam>
    public interface IEmPageGenericEntityRequest<TEntity>
        where TEntity : class, IEntity, new()
    {
    }
}
