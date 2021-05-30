namespace Definux.Emeraude.Emails.Extensions
{
    /// <summary>
    /// Extensions for strings.
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Merge string and languageCode.
        /// </summary>
        /// <param name="targetString"></param>
        /// <param name="languageCode"></param>
        /// <returns></returns>
        public static string ToLanguageSuffix(this string targetString, string languageCode)
        {
            return $"{targetString}.{languageCode}";
        }
    }
}
