using System;

namespace Definux.Emeraude.Domain.Entities
{
    /// <summary>
    /// Interface that represent the domain entity.
    /// </summary>
    public interface IEntity
    {
        /// <summary>
        /// Identification of the entity.
        /// </summary>
        Guid Id { get; set; }
    }
}
