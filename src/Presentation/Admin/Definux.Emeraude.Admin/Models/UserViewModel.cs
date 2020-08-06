using Definux.Emeraude.Admin.Attributes;
using Definux.Emeraude.Admin.UI.UIElements.DetailsCard.Implementations;
using Definux.Emeraude.Admin.UI.UIElements.Table.Implementations;
using Definux.Emeraude.Application.Common.Mapping;
using Definux.Emeraude.Identity.Entities;
using System;

namespace Definux.Emeraude.Admin.Models
{
    public class UserViewModel : IMapFrom<User>
    {
        [DetailsCard(0, "Id", typeof(DetailsCardTextElement))]
        public string Id { get; set; }

        [TableColumn(1, "Email", typeof(TableTextElement))]
        [DetailsCard(1, "Email", typeof(DetailsCardTextElement))]
        public string Email { get; set; }

        [TableColumn(2, "Name", typeof(TableTextElement))]
        [DetailsCard(2, "Name", typeof(DetailsCardTextElement))]
        public string Name { get; set; }

        [TableColumn(3, "Registration", typeof(TableDateTimeElement))]
        [DetailsCard(3, "Registration", typeof(DetailsCardDateTimeElement))]
        public DateTime RegistrationDate { get; set; }

        [TableColumn(4, "2FA", typeof(TableFlagElement))]
        [DetailsCard(4, "Two Factor Enabled", typeof(DetailsCardFlagElement))]
        public bool TwoFactorEnabled { get; set; }

        [TableColumn(5, "Locked Out", typeof(TableFlagElement))]
        [DetailsCard(5, "Locked Out", typeof(DetailsCardFlagElement))]
        public bool IsLockedOut { get; set; }
    }
}
