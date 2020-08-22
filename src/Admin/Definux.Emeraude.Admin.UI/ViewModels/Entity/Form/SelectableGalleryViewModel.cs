using System.Collections.Generic;

namespace Definux.Emeraude.Admin.UI.ViewModels.Entity.Form
{
    public class SelectableGalleryViewModel
    {
        public string Controller { get; set; }

        public string Action { get; set; }

        public List<string> Pictures { get; set; }

        public string SelectedPicture { get; set; }
    }
}
