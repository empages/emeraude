using System.ComponentModel.DataAnnotations.Schema;

namespace Definux.Emeraude.Domain.Logging
{
    public class ErrorLog : LoggerEntity
    {
        public string StackTrace { get; set; }

        public string Source { get; set; }

        public string Message { get; set; }

        public string Method { get; set; }

        public string Class { get; set; }
    }
}
