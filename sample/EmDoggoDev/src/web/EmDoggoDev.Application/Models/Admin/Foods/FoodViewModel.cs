using Definux.Emeraude.Admin.Attributes;
using Definux.Emeraude.Admin.UI.UIElements.DetailsCard.Implementations;
using Definux.Emeraude.Admin.UI.UIElements.Form.Implementations;
using Definux.Emeraude.Admin.UI.UIElements.Table.Implementations;
using Definux.Emeraude.Admin.UI.ViewModels.Entity.Form;
using Definux.Emeraude.Application.Common.Mapping;
using EmDoggoDev.Domain.Common;
using EmDoggoDev.Domain.Entities;
using System;

namespace EmDoggoDev.Application.Models.Admin.Foods
{
    public class FoodViewModel : CreateEditEntityViewModel, IMapFrom<Food>
    {
        [DetailsCard(0, "Id", typeof(DetailsCardTextElement))]
        public string Id { get; set; }

        [TableColumn(1, "Name", typeof(TableTextElement))]
        [DetailsCard(1, "Name", typeof(DetailsCardTextElement))]
        [FormInput(1, "Name", typeof(FormTextElement))]
        public string Name { get; set; }

        [TableColumn(2, "Manufacturer", typeof(TableTextElement))]
        [DetailsCard(2, "Manufacturer", typeof(DetailsCardTextElement))]
        [FormInput(2, "Manufacturer", typeof(FormEnumDropdownElement))]
        public FoodManufacturer Manufacturer { get; set; }

        [FormInput(3, "Dummy Flag", typeof(FormFlagElement))]
        public bool DummyFlag { get; set; }

        [FormInput(4, "Dummy Manufacturers Checkbox (Not bindable)", typeof(FormEnumCheckboxGroupElement))]
        public FoodManufacturer[] Manufacturers { get; set; }

        [FormInput(5, "Dummy Manufacturers Radio (Not bindable)", typeof(FormEnumRadioGroupElement))]
        public FoodManufacturer ManufacturerRadio { get; set; }

        [FormInput(6, "Dummy Date (Not bindable)", typeof(FormDateElement))]
        public DateTime DummyDate { get; set; }

        [FormInput(7, "Dummy Time (Not bindable)", typeof(FormTimeElement))]
        public TimeSpan DummyTime { get; set; }
    }
}
