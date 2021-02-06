using System;
using Definux.Emeraude.Admin.Attributes;
using Definux.Emeraude.Admin.UI.UIElements.Details.Implementations;
using Definux.Emeraude.Admin.UI.UIElements.Form.Implementations;
using Definux.Emeraude.Admin.UI.UIElements.Table.Implementations;
using Definux.Emeraude.Admin.UI.ViewModels.Entity.Form;
using Definux.Emeraude.Application.Mapping;
using Definux.Emeraude.Tests.Admin.Integration.Setup.Domain;

namespace Definux.Emeraude.Tests.Admin.Integration.Setup.Application.Models
{
    public class SimpleEntityViewModel : EntityFormViewModel, IMapFrom<SimpleEntity>
    {
        [EntityIdentifier]
        [DetailsField(0, typeof(DetailsFieldTextElement))]
        public string Id { get; set; }

        [TableColumn(1, typeof(TableTextElement))]
        [DetailsField(1, typeof(DetailsFieldTextElement))]
        [FormInput(1, typeof(FormTextElement))]
        public string Name { get; set; }
        
        [TableColumn(2, typeof(TableTextElement))]
        [DetailsField(2, typeof(DetailsFieldTextElement))]
        [FormInput(2, typeof(FormTextElement))]
        public string Description { get; set; }
        
        [TableColumn(3, typeof(TableTextElement))]
        [DetailsField(3, typeof(DetailsFieldTextElement))]
        [FormInput(3, typeof(FormEnumDropdownElement))]
        public DayOfWeek Day { get; set; }
    }
}