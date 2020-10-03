using System;

namespace Definux.Emeraude.Domain.Entities
{
    /// <summary>
    /// Abstract class that represent the domain entity.
    /// </summary>
    public abstract class Entity : IEntity
    {
        /// <inheritdoc/>
        public Guid Id { get; set; }
    }
}
