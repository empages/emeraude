using Definux.Emeraude.Admin.Attributes;
using Definux.Emeraude.Admin.UI.UIElements.DetailsCard.Implementations;
using Definux.Emeraude.Admin.UI.UIElements.Form.Implementations;
using Definux.Emeraude.Admin.UI.UIElements.Table.Implementations;
using Definux.Emeraude.Admin.UI.ViewModels.Entity.Form;
using Definux.Emeraude.Application.Common.Mapping;
using EmDoggoDev.Application.Common.UIElements;
using EmDoggoDev.Domain.Entities;
using System;

namespace EmDoggoDev.Application.Models.Admin.Shops
{
    public class ShopFoodViewModel : CreateEditEntityViewModel, IMapFrom<ShopFood>
    {
        [DetailsCard(0, "Id", typeof(DetailsCardTextElement))]
        public string Id { get; set; }

        [TableColumn(1, "Food", typeof(TableFoodNameElement))]
        [FormInput(1, "Food", typeof(FormDatabaseDropdownElement), typeof(Food), nameof(Food.Name))]
        public Guid FoodId { get; set; }

        [TableColumn(2, "Amount", typeof(TableTextElement))]
        [DetailsCard(2, "Amount", typeof(DetailsCardTextElement))]
        [FormInput(2, "Amount", typeof(FormNumberElement))]
        public double Amount { get; set; }
    }
}
