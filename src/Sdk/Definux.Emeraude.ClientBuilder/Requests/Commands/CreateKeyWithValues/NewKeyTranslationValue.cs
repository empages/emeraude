namespace Definux.Emeraude.ClientBuilder.Requests.Commands.CreateKeyWithValues
{
    /// <summary>
    /// New key value.
    /// </summary>
    public class NewKeyTranslationValue
    {
        /// <summary>
        /// Language id.
        /// </summary>
        public int LanguageId { get; set; }

        /// <summary>
        /// Value of the translation.
        /// </summary>
        public string Value { get; set; }
    }
}
