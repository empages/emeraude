using System.Collections.Generic;

namespace Definux.Emeraude.Admin.EmPages.UI.Models.DetailsView
{
    /// <summary>
    /// Data implementation for details view.
    /// </summary>
    public class EmPageDetailsViewData
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmPageDetailsViewData"/> class.
        /// </summary>
        public EmPageDetailsViewData()
        {
            this.Fields = new List<EmPageDetailsFieldModel>();
        }

        /// <summary>
        /// Fields of the details view.
        /// </summary>
        public List<EmPageDetailsFieldModel> Fields { get; set; }
    }
}