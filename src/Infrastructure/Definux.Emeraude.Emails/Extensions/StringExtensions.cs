namespace Definux.Emeraude.Emails.Extensions
{
    public static class StringExtensions
    {
        public static string ToLanguageSuffix(this string targetString, string languageCode)
        {
            return $"{targetString}.{languageCode}";
        }
    }
}
