using System.Collections.Generic;

namespace Definux.Emeraude.ClientBuilder.Requests.Queries.GetTranslationsGridData
{
    /// <summary>
    /// Transformed translations and their referenced keys into grid format.
    /// </summary>
    public class TranslationsGridDataResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationsGridDataResult"/> class.
        /// </summary>
        public TranslationsGridDataResult()
        {
            this.Items = new List<TranslationsGridItem>();
        }

        /// <summary>
        /// Rows items of the grid.
        /// </summary>
        public List<TranslationsGridItem> Items { get; set; }
    }
}
