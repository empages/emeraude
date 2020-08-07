using System.ComponentModel.DataAnnotations;

namespace Definux.Emeraude.Admin.UI.ViewModels.Roots
{
    public class RootCreateFolderViewModel
    {
        [Required(ErrorMessage = "Folder name is a required field.")]
        public string FolderName { get; set; }

        public string Root { get; set; }

        public string ParentFolderPath { get; set; }
    }
}
