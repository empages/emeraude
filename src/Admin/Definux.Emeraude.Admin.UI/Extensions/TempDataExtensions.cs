using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace Definux.Emeraude.Admin.UI.Extensions
{
    public static class TempDataExtensions
    {
        public static bool TryGetSuccessMessage(this ITempDataDictionary tempData, out string message)
        {
            object valueObject = null;
            bool result = tempData.TryGetValue("SuccessStatusMessage", out valueObject);
            message = valueObject?.ToString();

            return result;
        }

        public static bool TryGetErrorMessage(this ITempDataDictionary tempData, out string message)
        {
            object valueObject = null;
            bool result = tempData.TryGetValue("ErrorStatusMessage", out valueObject);
            message = valueObject?.ToString();

            return result;
        }
    }
}
