using System.Collections.Generic;

namespace Definux.Emeraude.Admin.EmPages.UI.Models.DetailsView
{
    /// <summary>
    /// Schema implementation for table view.
    /// </summary>
    public class EmPageDetailsViewSchema : EmPageViewSchema
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmPageDetailsViewSchema"/> class.
        /// </summary>
        /// <param name="context"></param>
        public EmPageDetailsViewSchema(EmPageViewContext context)
            : base(context)
        {
            this.Features = new List<EmPageDetailsFeature>();
        }

        /// <summary>
        /// List of all details feature of current EmPage.
        /// </summary>
        public IList<EmPageDetailsFeature> Features { get; set; }
    }
}