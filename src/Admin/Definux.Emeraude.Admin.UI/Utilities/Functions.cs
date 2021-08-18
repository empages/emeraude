using System;
using System.Collections.Generic;
using Definux.Emeraude.Domain.Entities;

namespace Definux.Emeraude.Admin.UI.Utilities
{
    /// <summary>
    /// Static utility functions for the purposes of Admin UI.
    /// </summary>
    public static class Functions
    {
        /// <summary>
        /// Convert collection of entities to a dictionary with id as a key and specified property as a value.
        /// </summary>
        /// <param name="databaseEntities"></param>
        /// <param name="visibleProperty"></param>
        /// <returns></returns>
        public static Dictionary<Guid, string> GetDatabaseEntityDictionary(IEnumerable<IEntity> databaseEntities, string visibleProperty)
        {
            var databaseEntitiesDictionary = new Dictionary<Guid, string>();
            foreach (var entity in databaseEntities)
            {
                databaseEntitiesDictionary[entity.Id] = entity.GetType().GetProperty(visibleProperty)?.GetValue(entity)?.ToString();
            }

            return databaseEntitiesDictionary;
        }
    }
}
