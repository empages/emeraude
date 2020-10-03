using System;

namespace Definux.Emeraude.Domain.Entities
{
    /// <summary>
    /// Abstract class that represent domain entity with additional auditable information.
    /// </summary>
    public abstract class AuditableEntity : Entity, IAuditableEntity
    {
        /// <inheritdoc/>
        public DateTime CreatedOn { get; set; }

        /// <inheritdoc/>
        public string CreatedBy { get; set; }

        /// <inheritdoc/>
        public DateTime UpdatedOn { get; set; }

        /// <inheritdoc/>
        public string UpdatedBy { get; set; }
    }
}
