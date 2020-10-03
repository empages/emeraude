using System.Text;
using Definux.Emeraude.Admin.UI.TagHelpers;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Definux.Emeraude.Admin.UI.Extensions
{
    /// <summary>
    /// Extensions for <see cref="ViewContext"/>.
    /// </summary>
    public static class ViewContextExtensions
    {
        /// <summary>
        /// Append line into the content of the body.
        /// </summary>
        /// <param name="viewContext"></param>
        /// <param name="bodyLine"></param>
        public static void AppendIntoTheBody(this ViewContext viewContext, string bodyLine)
        {
            if (viewContext.ViewData[typeof(BodyTagHelper).FullName] == null)
            {
                viewContext.ViewData[typeof(BodyTagHelper).FullName] = new StringBuilder();
            }

            ((StringBuilder)viewContext.ViewData[typeof(BodyTagHelper).FullName]).AppendLine(bodyLine);
        }

        /// <summary>
        /// Append line into the content of the head.
        /// </summary>
        /// <param name="viewContext"></param>
        /// <param name="headLine"></param>
        public static void AppendIntoTheHead(this ViewContext viewContext, string headLine)
        {
            if (viewContext.ViewData[typeof(HeadTagHelper).FullName] == null)
            {
                viewContext.ViewData[typeof(HeadTagHelper).FullName] = new StringBuilder();
            }

            ((StringBuilder)viewContext.ViewData[typeof(HeadTagHelper).FullName]).AppendLine(headLine);
        }
    }
}
