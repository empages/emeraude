using System;

namespace Definux.Emeraude.Admin.UI.ViewModels.System
{
    /// <summary>
    /// ViewModel encapsulated error log item.
    /// </summary>
    public class ErrorLogViewModel
    {
        /// <summary>
        /// Id of the error log.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Date of creation of the error log.
        /// </summary>
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// Creator of the error log.
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// User that create error log.
        /// </summary>
        public ErrorLogUser? InvolvedUser { get; set; }

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

        /// <summary>
        /// Class from where comes the error log.
        /// </summary>
        public string Class { get; set; }

        /// <summary>
        /// Helper struct for encapsulate error log user.
        /// </summary>
        public struct ErrorLogUser
        {
            /// <summary>
            /// Email of the user.
            /// </summary>
            public string Email { get; set; }

            /// <summary>
            /// Name of the user.
            /// </summary>
            public string Name { get; set; }
        }
    }
}
