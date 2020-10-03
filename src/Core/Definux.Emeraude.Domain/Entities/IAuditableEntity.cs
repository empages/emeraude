using System;

namespace Definux.Emeraude.Domain.Entities
{
    /// <summary>
    /// Interface that represent domain entity with additional auditable information.
    /// </summary>
    public interface IAuditableEntity : IEntity
    {
        /// <summary>
        /// Date of creation of the entity.
        /// </summary>
        DateTime CreatedOn { get; set; }

        /// <summary>
        /// Identification of the user that create the entity.
        /// </summary>
        string CreatedBy { get; set; }

        /// <summary>
        /// Date of last modification of the entity.
        /// </summary>
        DateTime UpdatedOn { get; set; }

        /// <summary>
        /// Identification of the user that last modified the entity.
        /// </summary>
        string UpdatedBy { get; set; }
    }
}
