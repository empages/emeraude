using System;
using System.Collections.Generic;

namespace Definux.Emeraude.Admin.UI.ViewModels.Roots
{
    /// <summary>
    /// ViewModel of the roots (public and private) actions of file management feature of the application.
    /// </summary>
    public class RootViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RootViewModel"/> class.
        /// </summary>
        public RootViewModel()
        {
            this.Folders = new List<RootFolderViewModel>();
            this.Files = new List<RootFileViewModel>();
        }

        /// <summary>
        /// Name of the target root.
        /// </summary>
        public string Root { get; set; }

        /// <summary>
        /// Current folder name.
        /// </summary>
        public string FolderName { get; set; }

        /// <summary>
        /// List of all folders implemented by <see cref="RootFolderViewModel"/> in the current folder.
        /// </summary>
        public List<RootFolderViewModel> Folders { get; private set; }

        /// <summary>
        /// List of all files implemented by <see cref="RootFileViewModel"/> in the current folder.
        /// </summary>
        public List<RootFileViewModel> Files { get; private set; }

        /// <summary>
        /// Add file to the list of files.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="relativePath"></param>
        /// <param name="fileSize"></param>
        /// <param name="createdOn"></param>
        /// <param name="lastModifiedOn"></param>
        public void AddFile(string name, string relativePath, long fileSize, DateTime createdOn, DateTime lastModifiedOn)
        {
            this.Files.Add(new RootFileViewModel
            {
                Name = name,
                RelativePath = relativePath,
                Size = fileSize,
                CreatedOn = createdOn,
                LastModifiedOn = lastModifiedOn,
            });
        }

        /// <summary>
        /// Add folder to the list of files.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="relativePath"></param>
        /// <param name="createdOn"></param>
        /// <param name="lastModifiedOn"></param>
        public void AddFolder(string name, string relativePath, DateTime createdOn, DateTime lastModifiedOn)
        {
            this.Folders.Add(new RootFolderViewModel
            {
                Name = name,
                RelativePath = relativePath,
                CreatedOn = createdOn,
                LastModifiedOn = lastModifiedOn,
            });
        }
    }
}
