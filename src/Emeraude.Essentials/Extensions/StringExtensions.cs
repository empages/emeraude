using System.Linq;

namespace Emeraude.Essentials.Extensions
{
    /// <summary>
    /// Extensions for <see cref="string"/>.
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Get plural of the string.
        /// </summary>
        /// <param name="targetString"></param>
        /// <returns></returns>
        public static string ToPluralString(this string targetString)
        {
            string resultString = $"{targetString}s";
            if (targetString.EndsWith("s", System.StringComparison.OrdinalIgnoreCase) ||
                targetString.EndsWith("sh", System.StringComparison.OrdinalIgnoreCase) ||
                targetString.EndsWith("ch", System.StringComparison.OrdinalIgnoreCase) ||
                targetString.EndsWith("x", System.StringComparison.OrdinalIgnoreCase) ||
                targetString.EndsWith("z", System.StringComparison.OrdinalIgnoreCase))
            {
                resultString = $"{targetString}es";
            }

            return resultString;
        }

        /// <summary>
        /// Transforms the first char of string in uppercase.
        /// </summary>
        /// <param name="stringValue"></param>
        /// <returns></returns>
        public static string ToFirstUpper(this string stringValue)
        {
            return stringValue.First().ToString().ToUpper() + stringValue.Substring(1);
        }

        /// <summary>
        /// Transforms the first char of string in lowercase.
        /// </summary>
        /// <param name="stringValue"></param>
        /// <returns></returns>
        public static string ToFirstLower(this string stringValue)
        {
            return stringValue.First().ToString().ToLower() + stringValue.Substring(1);
        }
    }
}
