using System;

namespace Definux.Emeraude.Application.Common.Results.Files
{
    public class SystemFileItem
    {
        public string Name { get; set; }

        public FileSystemItemType Type { get; set; }

        public string Path { get; set; }

        public string RelativePath { get; set; }

        public long FileSize { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime LastModifiedOn { get; set; }
    }

    public enum FileSystemItemType
    {
        File = 1,
        Folder = 2
    }
}
