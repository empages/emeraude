using System;

namespace Definux.Emeraude.Admin.UI.ViewModels.Roots
{
    public class RootFolderViewModel
    {
        public string Name { get; set; }

        public string RelativePath { get; set; }

        public string RelativePathUrlFormat
        {
            get
            {
                return RelativePath.Substring(1).Replace("\\", "/");
            }
        }

        public DateTime CreatedOn { get; set; }

        public DateTime LastModifiedOn { get; set; }
    }
}
