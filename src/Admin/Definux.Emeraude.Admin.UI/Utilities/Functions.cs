using Definux.Emeraude.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Definux.Emeraude.Admin.UI.Utilities
{
    public static class Functions
    {
        public static Dictionary<Guid, string> GetDatabaseEntityDictionary(IEnumerable<IEntity> databaseEntities, string visibleProperty)
        {
            var databaseEntitiesDictionary = new Dictionary<Guid, string>();
            foreach (var entity in databaseEntities)
            {
                databaseEntitiesDictionary[entity.Id] = entity.GetType().GetProperty(visibleProperty).GetValue(entity)?.ToString();
            }

            return databaseEntitiesDictionary;
        }
    }
}
