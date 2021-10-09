using System;

namespace Definux.Emeraude.Admin.UI.Models.Logging
{
    /// <summary>
    /// Abstraction defines the log entity model.
    /// </summary>
    public abstract class LogEntityModel
    {
        /// <summary>
        /// Id of the log.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Date of creation of the log.
        /// </summary>
        public DateTimeOffset CreatedOn { get; set; }

        /// <summary>
        /// Creator of the log.
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// User that create error log.
        /// </summary>
        public LogUserModel InvolvedUser { get; set; }
    }
}