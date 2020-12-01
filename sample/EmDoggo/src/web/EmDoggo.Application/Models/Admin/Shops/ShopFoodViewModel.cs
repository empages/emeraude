using Definux.Emeraude.Admin.Attributes;
using Definux.Emeraude.Admin.UI.UIElements.DetailsCard.Implementations;
using Definux.Emeraude.Admin.UI.UIElements.Form.Implementations;
using Definux.Emeraude.Admin.UI.UIElements.Table.Implementations;
using Definux.Emeraude.Admin.UI.ViewModels.Entity.Form;
using Definux.Emeraude.Application.Mapping;
using EmDoggo.Domain.Entities;
using System;

namespace EmDoggo.Application.Models.Admin.Shops
{
    public class ShopFoodViewModel : CreateEditEntityViewModel, IMapFrom<ShopFood>
    {
        [DetailsCard(0, typeof(DetailsCardTextElement))]
        public string Id { get; set; }

        [FormInput(1, typeof(FormDatabaseDropdownElement), typeof(Food), nameof(Food.Name))]
        public Guid FoodId { get; set; }

        [TableColumn(2, typeof(TableTextElement))]
        [DetailsCard(2, typeof(DetailsCardTextElement))]
        [FormInput(2, typeof(FormNumberElement))]
        public double Amount { get; set; }
    }
}
