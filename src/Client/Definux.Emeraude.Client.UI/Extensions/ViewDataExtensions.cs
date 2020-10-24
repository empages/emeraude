using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace Definux.Emeraude.Client.UI.Extensions
{
    /// <summary>
    /// Extensions for <see cref="ViewDataDictionary"/>.
    /// </summary>
    public static class ViewDataExtensions
    {
        /// <summary>
        /// Set title to the ViewData.
        /// </summary>
        /// <param name="viewData"></param>
        /// <param name="title"></param>
        /// <returns></returns>
        public static ViewDataDictionary SetTitle(this ViewDataDictionary viewData, string title)
        {
            viewData["Title"] = title;
            return viewData;
        }
    }
}
