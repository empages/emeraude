using System;
using Definux.Emeraude.Admin.Attributes;
using Definux.Emeraude.Admin.UI.UIElements.Details.Implementations;
using Definux.Emeraude.Admin.UI.UIElements.Form.Implementations;
using Definux.Emeraude.Admin.UI.UIElements.Table.Implementations;
using Definux.Emeraude.Admin.UI.ViewModels.Entity.Form;
using Definux.Emeraude.Application.Mapping;
using EmDoggo.Domain.Entities;

namespace EmDoggo.Application.Models.Admin.Shops
{
    public class ShopViewModel : EntityFormViewModel, IMapFrom<Shop>
    {
        [DetailsField(0, typeof(DetailsFieldTextElement))]
        public string Id { get; set; }

        [TableColumn(1, typeof(TableTextElement))]
        [DetailsField(1, typeof(DetailsFieldTextElement))]
        [FormInput(1, typeof(FormTextElement))]
        public string Name { get; set; }

        [TableColumn(2, typeof(TableLongTextElement))]
        [DetailsField(2, typeof(DetailsFieldHtmlContentElement))]
        [FormInput(2, typeof(FormHtmlEditorElement))]
        public string Description { get; set; }

        [FormInput(3, typeof(FormDateElement))]
        public DateTime? DummyDateNullable { get; set; }
        
        [FormInput(4, typeof(FormDateElement))]
        public DateTime DummyDate { get; set; }
    }
}
