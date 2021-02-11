using System;

namespace Definux.Emeraude.Admin.UI.ViewModels.Logging
{
    /// <summary>
    /// ViewModel encapsulated error log item.
    /// </summary>
    public class ErrorLogViewModel : LogEntityViewModel
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
