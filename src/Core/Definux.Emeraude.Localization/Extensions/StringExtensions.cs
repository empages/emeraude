using System;

namespace Definux.Emeraude.Localization.Extensions
{
    public static class StringExtensions
    {
        public static string GetLanguageCodeFromUrl(this string url)
        {
            string returnUrlLanguageCode = null;
            try
            {
                if (!string.IsNullOrWhiteSpace(url))
                {
                    string tempReturnUrl = url;
                    if (url.StartsWith("/", StringComparison.OrdinalIgnoreCase))
                    {
                        tempReturnUrl = tempReturnUrl.Substring(1);
                    }
                    string returnUrlLanguagePart = tempReturnUrl.Substring(0, 3);
                    if (returnUrlLanguagePart.EndsWith("/", StringComparison.OrdinalIgnoreCase))
                    {
                        returnUrlLanguageCode = returnUrlLanguagePart.Substring(0, 2);
                    }
                }
            }
            catch (Exception) { }

            return returnUrlLanguageCode;
        }
    }
}
