using System;

namespace Definux.Emeraude.Admin.UI.ViewModels.Roots
{
    /// <summary>
    /// Implementation of root folder of the system.
    /// </summary>
    public class RootFolderViewModel
    {
        /// <summary>
        /// Name of the folder.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Relative path of the folder.
        /// </summary>
        public string RelativePath { get; set; }

        /// <summary>
        /// URL of the folder.
        /// </summary>
        public string RelativePathUrlFormat
        {
            get
            {
                return this.RelativePath.Substring(1).Replace("\\", "/");
            }
        }

        /// <summary>
        /// Creation date of the folder.
        /// </summary>
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// Last modification date of the folder.
        /// </summary>
        public DateTime LastModifiedOn { get; set; }
    }
}
