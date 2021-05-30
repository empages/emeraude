using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace Definux.Emeraude.Admin.UI.Extensions
{
    /// <summary>
    /// Extensions for <see cref="ITempDataDictionary"/>.
    /// </summary>
    public static class TempDataExtensions
    {
        /// <summary>
        /// Gets success message or null.
        /// </summary>
        /// <param name="tempData"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public static bool TryGetSuccessMessage(this ITempDataDictionary tempData, out string message)
        {
            bool result = tempData.TryGetValue("SuccessStatusMessage", out var valueObject);
            message = valueObject?.ToString();

            return result;
        }

        /// <summary>
        /// Gets error message or null.
        /// </summary>
        /// <param name="tempData"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public static bool TryGetErrorMessage(this ITempDataDictionary tempData, out string message)
        {
            bool result = tempData.TryGetValue("ErrorStatusMessage", out var valueObject);
            message = valueObject?.ToString();

            return result;
        }
    }
}
