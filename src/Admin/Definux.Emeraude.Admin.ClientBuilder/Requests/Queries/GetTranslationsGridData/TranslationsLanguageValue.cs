namespace Definux.Emeraude.Admin.ClientBuilder.Requests.Queries.GetTranslationsGridData
{
    /// <summary>
    /// Cell implementation for the grid row item <see cref="TranslationsGridItem"/>.
    /// </summary>
    public class TranslationsLanguageValue
    {
        /// <summary>
        /// Short code of the referenced language.
        /// </summary>
        public string LanguageCode { get; set; }

        /// <summary>
        /// Id of the translation.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Value of the translation.
        /// </summary>
        public string Value { get; set; }
    }
}
