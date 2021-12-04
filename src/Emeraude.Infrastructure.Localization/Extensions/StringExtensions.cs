using System;

namespace Emeraude.Infrastructure.Localization.Extensions;

/// <summary>
/// Extensions for strings.
/// </summary>
public static class StringExtensions
{
    /// <summary>
    /// Extract language code from specified URL.
    /// </summary>
    /// <param name="url"></param>
    /// <returns></returns>
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
        catch (Exception)
        {
        }

        return returnUrlLanguageCode;
    }
}