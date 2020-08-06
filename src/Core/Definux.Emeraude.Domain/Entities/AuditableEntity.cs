using System;

namespace Definux.Emeraude.Domain.Entities
{
    public abstract class AuditableEntity : Entity, IAuditableEntity
    {
        public DateTime CreatedOn { get; set; }

        public string CreatedBy { get; set; }

        public DateTime UpdatedOn { get; set; }

        public string UpdatedBy { get; set; }
    }
}
