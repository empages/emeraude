using System;

namespace Definux.Emeraude.Admin.UI.ViewModels.Logging
{
    /// <summary>
    /// Encapsulates user registered the log.
    /// </summary>
    public class LogUserViewModel
    {
        /// <summary>
        /// Id of the user.
        /// </summary>
        public Guid Id { get; set; }

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