using System;

namespace Definux.Emeraude.Admin.UI.ViewModels.Logging
{
    /// <summary>
    /// Abstraction defines the log entity view model.
    /// </summary>
    public abstract class LogEntityViewModel
    {
        /// <summary>
        /// Id of the log.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Date of creation of the log.
        /// </summary>
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// Creator of the log.
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// User that create error log.
        /// </summary>
        public LogUserViewModel InvolvedUser { get; set; }
    }
}