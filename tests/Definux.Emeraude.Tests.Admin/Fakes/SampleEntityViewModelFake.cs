using System;
using Definux.Emeraude.Admin.Attributes;
using Definux.Emeraude.Admin.UI.UIElements.Details.Implementations;
using Definux.Emeraude.Admin.UI.UIElements.Form.Implementations;
using Definux.Emeraude.Admin.UI.UIElements.Table.Implementations;
using Definux.Emeraude.Admin.UI.ViewModels.Entity.Form;

namespace Definux.Emeraude.Tests.Admin.Fakes
{
    public class SampleEntityViewModelFake : EntityFormViewModel
    {
        public Guid Id { get; set; }

        [TableColumn(1, typeof(TableTextElement))]
        [DetailsField(1, typeof(DetailsFieldTextElement))]
        [FormInput(1, typeof(FormTextElement))]
        public string StringProperty { get; set; }

        [TableColumn(2, typeof(TableTextElement))]
        [DetailsField(2, typeof(DetailsFieldTextElement))]
        [FormInput(2, typeof(FormTextElement))]
        public int IntegerProperty { get; set; }

        [TableColumn(3, typeof(TableTextElement))]
        [DetailsField(3, typeof(DetailsFieldTextElement))]
        [FormInput(3, typeof(FormTextElement))]
        public double DoubleProperty { get; set; }

        [TableColumn(4, typeof(TableTextElement))]
        [DetailsField(4, typeof(DetailsFieldTextElement))]
        [FormInput(4, typeof(FormTextElement))]
        public DayOfWeek EnumProperty { get; set; }
    }
}