using System.Collections.Generic;

namespace Definux.Emeraude.Admin.EmPages.Schema.DetailsView
{
    /// <summary>
    /// Details view description.
    /// </summary>
    public class DetailsViewDescription : ViewDescription<DetailsViewItem>
    {
        /// <summary>
        /// List of all features for specified details view.
        /// </summary>
        public IList<EmPageFeature> Features { get; set; }
    }
}