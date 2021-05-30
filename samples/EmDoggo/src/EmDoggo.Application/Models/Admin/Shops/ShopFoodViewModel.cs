using Definux.Emeraude.Admin.Attributes;
using Definux.Emeraude.Admin.UI.UIElements.Form.Implementations;
using Definux.Emeraude.Admin.UI.UIElements.Table.Implementations;
using Definux.Emeraude.Admin.UI.ViewModels.Entity.Form;
using Definux.Emeraude.Application.Mapping;
using EmDoggo.Domain.Entities;
using System;
using Definux.Emeraude.Admin.UI.UIElements.Details.Implementations;
using EmDoggo.Application.DataSourceMaps;

namespace EmDoggo.Application.Models.Admin.Shops
{
    public class ShopFoodViewModel : EntityFormViewModel, IMapFrom<ShopFood>
    {
        [DetailsField(0, typeof(DetailsFieldTextElement))]
        public string Id { get; set; }

        [FormInput(1, typeof(FormDatabaseDropdownElement), typeof(Food), nameof(Food.Name))]
        [TableColumn(1, "Food", typeof(TableDataSourceMapElement<FoodDataSourceMap>))]
        [DetailsField(1, "Food", typeof(DetailsFieldDataSourceMapElement<FoodDataSourceMap>))]
        public Guid FoodId { get; set; }

        [TableColumn(2, typeof(TableTextElement))]
        [DetailsField(2, typeof(DetailsFieldTextElement))]
        [FormInput(2, typeof(FormNumberElement))]
        public double Amount { get; set; }
    }
}
