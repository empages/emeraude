using Definux.Emeraude.Admin.Attributes;
using Definux.Emeraude.Admin.UI.UIElements.DetailsCard.Implementations;
using Definux.Emeraude.Admin.UI.UIElements.Form.Implementations;
using Definux.Emeraude.Admin.UI.UIElements.Table.Implementations;
using Definux.Emeraude.Admin.UI.ViewModels.Entity.Form;
using Definux.Emeraude.Application.Mapping;
using EmDoggo.Domain.Entities;

namespace EmDoggo.Application.Models.Admin.Shops
{
    public class ShopViewModel : CreateEditEntityViewModel, IMapFrom<Shop>
    {
        [DetailsCard(0, typeof(DetailsCardTextElement))]
        public string Id { get; set; }

        [TableColumn(1, typeof(TableTextElement))]
        [DetailsCard(1, typeof(DetailsCardTextElement))]
        [FormInput(1, typeof(FormTextElement))]
        public string Name { get; set; }
    }
}
