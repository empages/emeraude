using Definux.Emeraude.Admin.Attributes;
using Definux.Emeraude.Admin.UI.UIElements.DetailsCard.Implementations;
using Definux.Emeraude.Admin.UI.UIElements.Form.Implementations;
using Definux.Emeraude.Admin.UI.UIElements.Table.Implementations;
using Definux.Emeraude.Admin.UI.ViewModels.Entity.Form;
using Definux.Emeraude.Application.Mapping;
using EmDoggoDev.Domain.Common;
using EmDoggoDev.Domain.Entities;

namespace EmDoggoDev.Application.Models.Admin.Dogs
{
    public class DogViewModel : CreateEditEntityViewModel, IMapFrom<Dog>
    {
        [DetailsCard(0, "Id", typeof(DetailsCardTextElement))]
        public string Id { get; set; }

        [TableColumn(1, "Name", typeof(TableTextElement))]
        [DetailsCard(1, "Name", typeof(DetailsCardTextElement))]
        public string Name { get; set; }

        [TableColumn(2, "Type", typeof(TableTextElement))]
        [DetailsCard(2, "Type", typeof(DetailsCardTextElement))]
        public DogType Type { get; set; }

        [TableColumn(3, "Breed", typeof(TableTextElement))]
        [DetailsCard(3, "Breed", typeof(DetailsCardTextElement))]
        public DogBreed Breed { get; set; }
    }
}
