namespace Definux.Emeraude.Admin.UI.Models.Logging
{
    /// <summary>
    /// Model encapsulated error log item.
    /// </summary>
    public class ErrorLogModel : LogEntityModel
    {
        /// <summary>
        /// Stack trace of the error log.
        /// </summary>
        public string StackTrace { get; set; }

        /// <summary>
        /// Source of the error log.
        /// </summary>
        public string Source { get; set; }

        /// <summary>
        /// Message of the error log.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Class method from where comes the error log.
        /// </summary>
        public string Method { get; set; }
    }
}
