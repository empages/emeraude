using System.Collections.Generic;

namespace Emeraude.Infrastructure.Localization.Persistence.Entities
{
    /// <summary>
    /// Class that represent language definition into the system.
    /// </summary>
    public class Language
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Language"/> class.
        /// </summary>
        public Language()
        {
            this.Translations = new HashSet<TranslationValue>();
        }

        /// <summary>
        /// Id of the language.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Language short code.
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// System name of the language.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Native name of the language.
        /// </summary>
        public string NativeName { get; set; }

        /// <summary>
        /// List of all translations for the language.
        /// </summary>
        public ICollection<TranslationValue> Translations { get; set; }

        /// <summary>
        /// List of all static content items for the language.
        /// </summary>
        public ICollection<StaticContent> StaticContentList { get; set; }

        /// <summary>
        /// Flag that indicates whether the language is set as default for the application.
        /// </summary>
        public bool IsDefault { get; set; }
    }
}
