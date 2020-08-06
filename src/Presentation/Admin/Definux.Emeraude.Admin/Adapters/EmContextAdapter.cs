using Definux.Emeraude.Admin.UI.Adapters;
using Definux.Emeraude.Application.Common.Interfaces.Persistence;
using Definux.Emeraude.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Definux.Emeraude.Admin.Adapters
{
    public class EmContextAdapter : IEmContextAdapter
    {
        private readonly IEmContext context;

        public EmContextAdapter(IEmContext context)
        {
            this.context = context;
        }

        public IEnumerable<IEntity> GetAllEntitiesByPropertyName(string name)
        {
            var entities = context.GetContextType().GetProperty(name).GetValue(context);
            if (entities != null)
            {
                return ((IEnumerable<IEntity>)entities).ToList();
            }

            return new List<IEntity>();
        }

        public IEnumerable<IEntity> GetAllEntitiesByType(Type entityType)
        {
            var entities = context
                .GetContextType()
                .GetProperties()
                .Where(x => x.PropertyType.GenericTypeArguments.Contains(entityType))
                .FirstOrDefault()?
                .GetValue(context);
            IEnumerable<IEntity> resultEntities = null;
            if (entities != null)
            {
                resultEntities = ((IEnumerable<IEntity>)entities).ToList();
            }

            return resultEntities;
        }
    }
}
