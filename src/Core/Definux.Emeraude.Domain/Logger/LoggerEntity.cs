using System;

namespace Definux.Emeraude.Domain.Logging
{
    public abstract class LoggerEntity : ILoggerEntity
    {
        public int Id { get; set; }

        public DateTime CreatedOn { get; set; }

        public string CreatedBy { get; set; }
    }
}
