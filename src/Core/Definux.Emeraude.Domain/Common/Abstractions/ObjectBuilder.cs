using Definux.Emeraude.Domain.Entities;

namespace Definux.Emeraude.Domain.Common.Abstractions
{
    public abstract class ObjectBuilder<TEntity, TEntityBuilder>
        where TEntity : class, IEntity, new()
        where TEntityBuilder : ObjectBuilder<TEntity, TEntityBuilder>, new()
    {
        protected readonly TEntity entity;

        protected ObjectBuilder()
        {
            this.entity = new TEntity();
        }

        public static TEntityBuilder Init()
        {
            return new TEntityBuilder();
        }

        public virtual TEntity Build()
        {
            return this.entity;
        }
    }
}
