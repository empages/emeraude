using System.Collections.Generic;

namespace Definux.Emeraude.Admin.UI.ViewModels.Entity.Form
{
    /// <summary>
    /// Implementation of view model specified to apply image to entity.
    /// </summary>
    public class SelectableGalleryViewModel
    {
        /// <summary>
        /// Name of the target controller of the action that using the view model.
        /// </summary>
        public string Controller { get; set; }

        /// <summary>
        /// Name of the target action that using the view model.
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// List of all images urls used for the form view.
        /// </summary>
        public List<string> Pictures { get; set; }

        /// <summary>
        /// Url of the selected image.
        /// </summary>
        public string SelectedPicture { get; set; }
    }
}
