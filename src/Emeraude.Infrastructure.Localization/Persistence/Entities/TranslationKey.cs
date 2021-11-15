using System.Collections.Generic;

namespace Emeraude.Infrastructure.Localization.Persistence.Entities
{
    /// <summary>
    /// Key of the translation.
    /// </summary>
    public class TranslationKey
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationKey"/> class.
        /// </summary>
        public TranslationKey()
        {
            this.Translations = new HashSet<TranslationValue>();
        }

        /// <summary>
        /// Id of the translation key.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Key of the translation key.
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// List of all translations which are using the key.
        /// </summary>
        public ICollection<TranslationValue> Translations { get; set; }
    }
}
