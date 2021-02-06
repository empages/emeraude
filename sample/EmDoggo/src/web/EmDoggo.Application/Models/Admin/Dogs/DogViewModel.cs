using Definux.Emeraude.Admin.Attributes;
using Definux.Emeraude.Admin.UI.UIElements.Details.Implementations;
using Definux.Emeraude.Admin.UI.UIElements.Form.Implementations;
using Definux.Emeraude.Admin.UI.UIElements.Table.Implementations;
using Definux.Emeraude.Admin.UI.ViewModels.Entity.Form;
using Definux.Emeraude.Application.Mapping;
using EmDoggo.Domain.Common;
using EmDoggo.Domain.Entities;

namespace EmDoggo.Application.Models.Admin.Dogs
{
    public class DogViewModel : EntityFormViewModel, IMapFrom<Dog>
    {
        [DetailsField(0, typeof(DetailsFieldTextElement))]
        public string Id { get; set; }

        [TableColumn(1, typeof(TableTextElement))]
        [DetailsField(1, typeof(DetailsFieldTextElement))]
        public string Name { get; set; }

        [TableColumn(2, typeof(TableTextElement))]
        [DetailsField(2, typeof(DetailsFieldTextElement))]
        public DogType Type { get; set; }

        [TableColumn(3, typeof(TableTextElement))]
        [DetailsField(3, typeof(DetailsFieldTextElement))]
        public DogBreed Breed { get; set; }
    }
}
