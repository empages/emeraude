namespace Definux.Emeraude.Domain.Logging
{
    /// <summary>
    /// Log that represent sending email try from the system.
    /// </summary>
    public class EmailLog : LoggerEntity
    {
        /// <summary>
        /// Receiver of the email.
        /// </summary>
        public string Receiver { get; set; }

        /// <summary>
        /// Subject of the email.
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// Body of the email.
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// Flag that indicates whether email is sent or not.
        /// </summary>
        public bool Sent { get; set; }
    }
}
