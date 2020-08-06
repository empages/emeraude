namespace Definux.Emeraude.Domain.Logging
{
    public class EmailLog : LoggerEntity
    {
        public string Receiver { get; set; }

        public string Subject { get; set; }

        public string Body { get; set; }

        public bool Sent { get; set; }
    }
}
