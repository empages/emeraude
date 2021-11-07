using System;

namespace Definux.Emeraude.Contracts
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
