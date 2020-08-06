using System;
using System.Collections.Generic;

namespace Definux.Emeraude.Admin.UI.ViewModels.Roots
{
    public class RootViewModel
    {
        public RootViewModel()
        {
            Folders = new List<RootFolderViewModel>();
            Files = new List<RootFileViewModel>();
        }

        public string Root { get; set; }

        public string FolderName { get; set; }

        public List<RootFolderViewModel> Folders { get; private set; }

        public List<RootFileViewModel> Files { get; private set; }

        public void AddFile(string name, string relativePath, long fileSize, DateTime createdOn, DateTime lastModifiedOn)
        {
            Files.Add(new RootFileViewModel
            {
                Name = name,
                RelativePath = relativePath,
                Size = fileSize,
                CreatedOn = createdOn,
                LastModifiedOn = lastModifiedOn
            });
        }

        public void AddFolder(string name, string relativePath, DateTime createdOn, DateTime lastModifiedOn)
        {
            Folders.Add(new RootFolderViewModel
            {
                Name = name,
                RelativePath = relativePath,
                CreatedOn = createdOn,
                LastModifiedOn = lastModifiedOn
            });
        }
    }
}
