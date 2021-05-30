namespace Definux.Emeraude.Admin.UI.ViewModels.Roots
{
    /// <summary>
    /// View model for uploading file.
    /// </summary>
    public class RootUploadFilesViewModel
    {
        /// <summary>
        /// Target root of the file.
        /// </summary>
        public string Root { get; set; }

        /// <summary>
        /// Target folder path.
        /// </summary>
        public string ParentFolderPath { get; set; }
    }
}
