using System;
using System.Collections.Generic;
using System.Linq;
using Definux.Emeraude.Admin.UI.Adapters;
using Definux.Emeraude.Application.Common.Interfaces.Persistence;
using Definux.Emeraude.Domain.Entities;

namespace Definux.Emeraude.Admin.Adapters
{
    /// <inheritdoc cref="IEmContextAdapter"/>
    public class EmContextAdapter : IEmContextAdapter
    {
        private readonly IEmContext context;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmContextAdapter"/> class.
        /// </summary>
        /// <param name="context"></param>
        public EmContextAdapter(IEmContext context)
        {
            this.context = context;
        }

        /// <inheritdoc/>
        public IEnumerable<IEntity> GetAllEntitiesByPropertyName(string name)
        {
            var entities = this.context.GetContextType().GetProperty(name).GetValue(this.context);
            if (entities != null)
            {
                return ((IEnumerable<IEntity>)entities).ToList();
            }

            return new List<IEntity>();
        }

        /// <inheritdoc/>
        public IEnumerable<IEntity> GetAllEntitiesByType(Type entityType)
        {
            var entities = this.context
                .GetContextType()
                .GetProperties()
                .Where(x => x.PropertyType.GenericTypeArguments.Contains(entityType))
                .FirstOrDefault()?
                .GetValue(this.context);
            IEnumerable<IEntity> resultEntities = null;
            if (entities != null)
            {
                resultEntities = ((IEnumerable<IEntity>)entities).ToList();
            }

            return resultEntities;
        }
    }
}
