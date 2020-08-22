using Definux.Emeraude.Admin.UI.UIElements.DetailsCard;
using Microsoft.AspNetCore.Html;

namespace Definux.Emeraude.Admin.UI.ViewModels.Entity.DetailsCard
{
    public class DetailsPropertyViewModel
    {
        public int Order { get; set; }

        public string Name { get; set; }

        public string KebapCaseName 
        { 
            get
            {
                return Name?.Replace(" ", "-").ToLower() ?? string.Empty;
            }
        }

        public object Value { get; set; }

        public IDetailsCardElement DetailsCardElement { get; set; }

        public IHtmlContent RenderHtmlContent()
        {
            DetailsCardElement.DataSource = Value;
            return DetailsCardElement.RenderHtmlString();
        }
    }
}
