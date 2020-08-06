using System;

namespace Definux.Emeraude.Domain.Logging
{
    public interface ILoggerEntity
    {
        int Id { get; set; }

        DateTime CreatedOn { get; set; }

        string CreatedBy { get; set; }
    }
}
