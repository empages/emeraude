using Definux.Emeraude.Domain.Entities;

namespace Definux.Emeraude.Domain.Common.Abstractions
{
    /// <summary>
    /// Abstract class that represent helper for create object builder for creation domein entity with builder pattern.
    /// </summary>
    /// <typeparam name="TEntity">Target entity.</typeparam>
    /// <typeparam name="TEntityBuilder">Target entity builder.</typeparam>
    public abstract class ObjectBuilder<TEntity, TEntityBuilder>
        where TEntity : class, IEntity, new()
        where TEntityBuilder : ObjectBuilder<TEntity, TEntityBuilder>, new()
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectBuilder{TEntity, TEntityBuilder}"/> class.
        /// </summary>
        protected ObjectBuilder()
        {
            this.Entity = new TEntity();
        }

        /// <summary>
        /// Target entity.
        /// </summary>
        protected TEntity Entity { get; set; }

        /// <summary>
        /// Initialization step for the builder.
        /// </summary>
        /// <returns></returns>
        public static TEntityBuilder Init()
        {
            return new TEntityBuilder();
        }

        /// <summary>
        /// Finalize method for the builder that build and return the target entity.
        /// </summary>
        /// <returns></returns>
        public virtual TEntity Build()
        {
            return this.Entity;
        }
    }
}
