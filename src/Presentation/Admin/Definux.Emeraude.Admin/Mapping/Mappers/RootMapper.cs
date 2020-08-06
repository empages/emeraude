using Definux.Emeraude.Admin.UI.ViewModels.Roots;
using System.Collections.Generic;

namespace Definux.Emeraude.Application.Common.Results.Files
{
    public static class RootMapper
    {
        public static RootViewModel Map(string folderName, IEnumerable<SystemFileItem> fileSystemItems)
        {
            RootViewModel model = new RootViewModel
            {
                FolderName = folderName
            };

            foreach (var item in fileSystemItems)
            {
                if (item.Type == FileSystemItemType.File)
                {
                    model.AddFile(item.Name, item.RelativePath, item.FileSize, item.CreatedOn, item.LastModifiedOn);
                }
                else if (item.Type == FileSystemItemType.Folder)
                {
                    model.AddFolder(item.Name, item.RelativePath, item.CreatedOn, item.LastModifiedOn);
                }
            }

            return model;
        }
    }
}
