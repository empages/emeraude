using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Definux.Emeraude.Client.UI.Adapters
{
    /// <summary>
    /// Adapter that builds meta tags content for the head of the HTML.
    /// </summary>
    public interface IHtmlMetaTagsBuilder
    {
        /// <summary>
        /// Gets meta tags HTML.
        /// </summary>
        /// <param name="viewContext"></param>
        /// <returns></returns>
        HtmlString GetCurrentPageMetaTags(ViewContext viewContext);
    }
}