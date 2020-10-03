using System;
using Definux.Utilities.Functions;

namespace Definux.Emeraude.Admin.UI.ViewModels.Roots
{
    /// <summary>
    /// Implementation of root file of the system.
    /// </summary>
    public class RootFileViewModel
    {
        /// <summary>
        /// Name of the file.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Relative path of the file.
        /// </summary>
        public string RelativePath { get; set; }

        /// <summary>
        /// URL of the file.
        /// </summary>
        public string RelativePathUrlFormat
        {
            get
            {
                return this.RelativePath.Substring(1).Replace("\\", "/");
            }
        }

        /// <summary>
        /// Size of the file.
        /// </summary>
        public long Size { get; set; }

        /// <summary>
        /// Size of the file with size suffix.
        /// </summary>
        public string SizeString
        {
            get
            {
                return FilesFunctions.SizeSuffix(this.Size, 2);
            }
        }

        /// <summary>
        /// Creation date of the file.
        /// </summary>
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// Last modification date of the file.
        /// </summary>
        public DateTime LastModifiedOn { get; set; }
    }
}
