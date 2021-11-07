using Definux.Emeraude.Essentials.Extensions;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace Definux.Emeraude.Presentation.PlatformBase.Extensions
{
    /// <summary>
    /// Extensions for <see cref="ViewDataDictionary"/>.
    /// </summary>
    public static class ViewDataExtensions
    {
        private const string TitleViewDataKey = "Title";

        /// <summary>
        /// Set title into the ViewData.
        /// </summary>
        /// <param name="viewData"></param>
        /// <param name="title"></param>
        public static void SetTitle(this ViewDataDictionary viewData, string title)
        {
            viewData[TitleViewDataKey] = title;
        }

        /// <summary>
        /// Gets title value from the ViewData.
        /// </summary>
        /// <param name="viewData"></param>
        /// <returns></returns>
        public static string GetTitle(this ViewDataDictionary viewData)
        {
            return viewData.GetValueOrDefault(TitleViewDataKey)?.ToString();
        }
    }
}
