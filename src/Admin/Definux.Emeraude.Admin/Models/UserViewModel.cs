using System;
using Definux.Emeraude.Admin.Attributes;
using Definux.Emeraude.Admin.UI.UIElements.DetailsCard.Implementations;
using Definux.Emeraude.Admin.UI.UIElements.Table.Implementations;
using Definux.Emeraude.Application.Common.Mapping;
using Definux.Emeraude.Identity.Entities;

namespace Definux.Emeraude.Admin.Models
{
    /// <summary>
    /// ViewModel of the user entity.
    /// </summary>
    public class UserViewModel : IMapFrom<User>
    {
        /// <inheritdoc cref="User.Id"/>
        [DetailsCard(0, "Id", typeof(DetailsCardTextElement))]
        public string Id { get; set; }

        /// <inheritdoc cref="User.Email"/>
        [TableColumn(1, "Email", typeof(TableTextElement))]
        [DetailsCard(1, "Email", typeof(DetailsCardTextElement))]
        public string Email { get; set; }

        /// <inheritdoc cref="User.Name"/>
        [TableColumn(2, "Name", typeof(TableTextElement))]
        [DetailsCard(2, "Name", typeof(DetailsCardTextElement))]
        public string Name { get; set; }

        /// <inheritdoc cref="User.RegistrationDate"/>
        [TableColumn(3, "Registration", typeof(TableDateTimeElement))]
        [DetailsCard(3, "Registration", typeof(DetailsCardDateTimeElement))]
        public DateTime RegistrationDate { get; set; }

        /// <summary>
        /// Flag that indicates whether the user is activate his/her two factor authentication.
        /// </summary>
        [TableColumn(4, "2FA", typeof(TableFlagElement))]
        [DetailsCard(4, "Two Factor Enabled", typeof(DetailsCardFlagElement))]
        public bool TwoFactorEnabled { get; set; }

        /// <inheritdoc cref="User.IsLockedOut"/>
        [TableColumn(5, "Locked Out", typeof(TableFlagElement))]
        [DetailsCard(5, "Locked Out", typeof(DetailsCardFlagElement))]
        public bool IsLockedOut { get; set; }
    }
}
