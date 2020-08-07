using Definux.Utilities.Functions;
using System;

namespace Definux.Emeraude.Admin.UI.ViewModels.Roots
{
    public class RootFileViewModel
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

        public long Size { get; set; }

        public string SizeString
        {
            get
            {
                return FilesFunctions.SizeSuffix(Size, 2);
            }
        }

        public DateTime CreatedOn { get; set; }

        public DateTime LastModifiedOn { get; set; }
    }
}
