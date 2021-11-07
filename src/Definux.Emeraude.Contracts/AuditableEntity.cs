using System;

namespace Definux.Emeraude.Contracts
{
    /// <summary>
    /// Abstract class that represent domain entity with additional auditable information.
    /// </summary>
    public abstract class AuditableEntity : Entity, IAuditableEntity
    {
        /// <inheritdoc/>
        public DateTimeOffset CreatedOn { get; set; }

        /// <inheritdoc/>
        public string CreatedBy { get; set; }

        /// <inheritdoc/>
        public DateTimeOffset UpdatedOn { get; set; }

        /// <inheritdoc/>
        public string UpdatedBy { get; set; }
    }
}
