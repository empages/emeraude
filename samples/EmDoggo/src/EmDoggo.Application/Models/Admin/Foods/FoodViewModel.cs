using Definux.Emeraude.Admin.Attributes;
using Definux.Emeraude.Admin.UI.UIElements.Form.Implementations;
using Definux.Emeraude.Admin.UI.UIElements.Table.Implementations;
using Definux.Emeraude.Admin.UI.ViewModels.Entity.Form;
using Definux.Emeraude.Application.Mapping;
using EmDoggo.Domain.Common;
using EmDoggo.Domain.Entities;
using System;
using Definux.Emeraude.Admin.UI.UIElements.Details.Implementations;
using Definux.Emeraude.Application.Models;

namespace EmDoggo.Application.Models.Admin.Foods
{
    public class FoodViewModel : EntityFormViewModel, IMapFrom<Food>
    {
        [DetailsField(0, typeof(DetailsFieldTextElement))]
        public string Id { get; set; }

        [TableColumn(1, typeof(TableTextElement))]
        [DetailsField(1, typeof(DetailsFieldTextElement))]
        [FormInput(1, typeof(FormTextElement))]
        public string Name { get; set; }

        [TableColumn(2, typeof(TableTextElement))]
        [DetailsField(2, typeof(DetailsFieldTextElement))]
        [FormInput(2, typeof(FormEnumDropdownElement))]
        public FoodManufacturer Manufacturer { get; set; }
        
        [TableColumn(3, typeof(TableDateTimeElement))]
        [DetailsField(3, typeof(DetailsFieldDateElement))]
        [FormInput(3, typeof(FormDateElement))]
        public DateModel RequiredDateTimeOffset { get; set; }
        
        [TableColumn(4, typeof(TableDateElement))]
        [DetailsField(4, typeof(DetailsFieldDateElement))]
        [FormInput(4, typeof(FormDateElement))]
        public DateModel? OptionalDateTimeOffset { get; set; }
        
        [TableColumn(5, typeof(TableDateTimeElement))]
        [DetailsField(5, typeof(DetailsFieldDateElement))]
        [FormInput(5, typeof(FormDateElement))]
        public DateModel RequiredDateTime { get; set; }

        [TableColumn(6, typeof(TableDateElement))]
        [DetailsField(6, typeof(DetailsFieldDateElement))]
        [FormInput(6, typeof(FormDateElement))]
        public DateModel? OptionalDateTime { get; set; }
    }
}
