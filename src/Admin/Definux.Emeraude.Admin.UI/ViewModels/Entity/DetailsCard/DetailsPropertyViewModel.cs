using Definux.Emeraude.Admin.UI.UIElements.DetailsCard;
using Microsoft.AspNetCore.Html;

namespace Definux.Emeraude.Admin.UI.ViewModels.Entity.DetailsCard
{
    /// <summary>
    /// Implementation of the details card row item.
    /// </summary>
    public class DetailsPropertyViewModel
    {
        /// <summary>
        /// Order of the property.
        /// </summary>
        public int Order { get; set; }

        /// <summary>
        /// Name of the property.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Name of the property in kebap case.
        /// </summary>
        public string KebapCaseName
        {
            get
            {
                return this.Name?.Replace(" ", "-").ToLower() ?? string.Empty;
            }
        }

        /// <summary>
        /// Value of the property.
        /// </summary>
        public object Value { get; set; }

        /// <summary>
        /// Render UI element of the property.
        /// </summary>
        public IDetailsCardElement DetailsCardElement { get; set; }

        /// <summary>
        /// Renders the HTML content for the current property.
        /// </summary>
        /// <returns></returns>
        public IHtmlContent RenderHtmlContent()
        {
            this.DetailsCardElement.DataSource = this.Value;
            return this.DetailsCardElement.RenderHtmlString();
        }
    }
}
