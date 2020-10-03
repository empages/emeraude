using System.Collections.Generic;
using Definux.Emeraude.Admin.UI.ViewModels.Roots;
using Definux.Emeraude.Application.Common.Models;
using Definux.Emeraude.Application.Common.Results.Files;

namespace Definux.Emeraude.Admin.Mapping.Mappers
{
    /// <summary>
    /// Static mapper that supports roots feature.
    /// </summary>
    public static class RootMapper
    {
        /// <summary>
        /// Method that sorting a collection of <see cref="SystemItem"/> into a <seealso cref="RootViewModel"/> files and folders.
        /// </summary>
        /// <param name="folderName"></param>
        /// <param name="fileSystemItems"></param>
        /// <returns></returns>
        public static RootViewModel Map(string folderName, IEnumerable<SystemItem> fileSystemItems)
        {
            RootViewModel model = new RootViewModel
            {
                FolderName = folderName,
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
