using System;
using System.Collections.Generic;
using System.Text;

namespace Emeraude.Application.ClientBuilder.Requests.Queries.GetTranslationsGridData
{
    /// <summary>
    /// Model that define the row item of the grid result <see cref="TranslationsGridDataResult"/>.
    /// </summary>
    public class TranslationsGridItem
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationsGridItem"/> class.
        /// </summary>
        public TranslationsGridItem()
        {
            this.LanguageValues = new List<TranslationLanguageValue>();
        }

        /// <summary>
        /// Translation key id.
        /// </summary>
        public int KeyId { get; set; }

        /// <summary>
        /// Translation key text.
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// List of all translations for the current key.
        /// </summary>
        public List<TranslationLanguageValue> LanguageValues { get; set; }
    }
}
