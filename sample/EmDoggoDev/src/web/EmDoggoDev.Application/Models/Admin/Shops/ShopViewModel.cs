using Definux.Emeraude.Admin.Attributes;
using Definux.Emeraude.Admin.UI.UIElements.DetailsCard.Implementations;
using Definux.Emeraude.Admin.UI.UIElements.Form.Implementations;
using Definux.Emeraude.Admin.UI.UIElements.Table.Implementations;
using Definux.Emeraude.Admin.UI.ViewModels.Entity.Form;
using Definux.Emeraude.Application.Mapping;
using EmDoggoDev.Domain.Entities;

namespace EmDoggoDev.Application.Models.Admin.Shops
{
    public class ShopViewModel : CreateEditEntityViewModel, IMapFrom<Shop>
    {
        [DetailsCard(0, "Id", typeof(DetailsCardTextElement))]
        public string Id { get; set; }

        [TableColumn(1, "Name", typeof(TableTextElement))]
        [DetailsCard(1, "Name", typeof(DetailsCardTextElement))]
        [FormInput(1, "Name", typeof(FormTextElement))]
        public string Name { get; set; }
    }
}
