using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace Definux.Emeraude.Admin.UI.Extensions
{
    /// <summary>
    /// Extensions for <see cref="IUrlHelper"/>.
    /// </summary>
    public static class UrlHelperExtensions
    {
        /// <summary>
        /// Gets default URL based on current action, controller and area.
        /// </summary>
        /// <param name="urlHelper"></param>
        /// <param name="viewData"></param>
        /// <returns></returns>
        public static string GetDefaultUrl(this IUrlHelper urlHelper, ViewDataDictionary viewData)
        {
            return urlHelper.Action(viewData.GetAction(), viewData.GetController(), new { Area = viewData.GetArea() });
        }
    }
}
