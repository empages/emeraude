using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace Definux.Emeraude.Admin.UI.Extensions
{
    public static class UrlHelperExtensions
    {
        public static string GetDefaultUrl(this IUrlHelper urlHelper, ViewDataDictionary viewData)
        {
            return urlHelper.Action(viewData.GetAction(), viewData.GetController(), new { Area = viewData.GetArea() });
        }
    }
}
