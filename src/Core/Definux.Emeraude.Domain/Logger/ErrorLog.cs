namespace Definux.Emeraude.Domain.Logging
{
    /// <summary>
    /// Log that represent errors and exception from the system.
    /// </summary>
    public class ErrorLog : LoggerEntity
    {
        /// <summary>
        /// Stack trace of the exception.
        /// </summary>
        public string StackTrace { get; set; }

        /// <summary>
        /// Error source.
        /// </summary>
        public string Source { get; set; }

        /// <summary>
        /// Error message.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Name of the from where the error comes.
        /// </summary>
        public string Method { get; set; }

        /// <summary>
        /// Name of the class from where the error comes.
        /// </summary>
        public string Class { get; set; }
    }
}
