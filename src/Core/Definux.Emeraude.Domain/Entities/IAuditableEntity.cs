using System;

namespace Definux.Emeraude.Domain.Entities
{
    public interface IAuditableEntity : IEntity
    {
        DateTime CreatedOn { get; set; }

        string CreatedBy { get; set; }

        DateTime UpdatedOn { get; set; }

        string UpdatedBy { get; set; }
    }
}
