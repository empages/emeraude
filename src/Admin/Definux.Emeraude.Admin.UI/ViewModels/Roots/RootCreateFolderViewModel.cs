using System.ComponentModel.DataAnnotations;

namespace Definux.Emeraude.Admin.UI.ViewModels.Roots
{
    /// <summary>
    /// View model for creating new folder.
    /// </summary>
    public class RootCreateFolderViewModel
    {
        /// <summary>
        /// Name of the folder.
        /// </summary>
        [Required(ErrorMessage = "Folder name is a required field.")]
        public string FolderName { get; set; }

        /// <summary>
        /// Target root.
        /// </summary>
        public string Root { get; set; }

        /// <summary>
        /// Target folder path.
        /// </summary>
        public string ParentFolderPath { get; set; }
    }
}
