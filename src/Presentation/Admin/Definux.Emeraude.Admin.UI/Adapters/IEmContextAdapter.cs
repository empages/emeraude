using Definux.Emeraude.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Definux.Emeraude.Admin.UI.Adapters
{
    public interface IEmContextAdapter
    {
        /// <summary>
        /// Get all entities from the database based on the type of the desired entity.
        /// </summary>
        /// <param name="entityType">Type of the desired entity.</param>
        /// <returns></returns>
        IEnumerable<IEntity> GetAllEntitiesByType(Type entityType);

        /// <summary>
        /// Get all entities from the database based on the property name.
        /// </summary>
        /// <param name="name">Name of the database context property.</param>
        /// <returns></returns>
        IEnumerable<IEntity> GetAllEntitiesByPropertyName(string name);
    }
}
