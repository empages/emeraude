using System;
using Definux.Emeraude.Admin.Attributes;
using Definux.Emeraude.Admin.UI.UIElements.Details.Implementations;
using Definux.Emeraude.Admin.UI.UIElements.Table.Implementations;
using Definux.Emeraude.Application.Mapping;
using Definux.Emeraude.Identity.Entities;

namespace Definux.Emeraude.Admin.Models
{
    /// <summary>
    /// ViewModel of the user entity.
    /// </summary>
    public class UserViewModel : IMapFrom<User>
    {
        /// <inheritdoc cref="User.Id"/>
        [DetailsField(0, typeof(DetailsFieldTextElement))]
        public string Id { get; set; }

        /// <inheritdoc cref="User.Email"/>
        [TableColumn(1, typeof(TableTextElement))]
        [DetailsField(1, typeof(DetailsFieldTextElement))]
        public string Email { get; set; }

        /// <inheritdoc cref="User.Name"/>
        [TableColumn(2, typeof(TableTextElement))]
        [DetailsField(2, typeof(DetailsFieldTextElement))]
        public string Name { get; set; }

        /// <inheritdoc cref="User.RegistrationDate"/>
        [TableColumn(3, "Registration", typeof(TableDateTimeElement))]
        [DetailsField(3, "Registration", typeof(DetailsFieldDateTimeElement))]
        public DateTime RegistrationDate { get; set; }

        /// <summary>
        /// Flag that indicates whether the user is activate his/her two factor authentication.
        /// </summary>
        [TableColumn(4, "2FA", typeof(TableFlagElement))]
        [DetailsField(4, typeof(DetailsFieldFlagElement))]
        public bool TwoFactorEnabled { get; set; }

        /// <inheritdoc cref="User.IsLockedOut"/>
        [TableColumn(5, "Locked Out", typeof(TableFlagElement))]
        [DetailsField(5, "Locked Out", typeof(DetailsFieldFlagElement))]
        public bool IsLockedOut { get; set; }

        /// <inheritdoc cref="User.EmailConfirmed"/>
        [TableColumn(6, "Email Confirmed", typeof(TableFlagElement))]
        [DetailsField(6, "Email Confirmed", typeof(DetailsFieldFlagElement))]
        public bool EmailConfirmed { get; set; }
    }
}
