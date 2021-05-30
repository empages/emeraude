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
        /// <summary>
        /// Identifier of the user.
        /// </summary>
        [DetailsField(0, typeof(DetailsFieldTextElement))]
        public string Id { get; set; }

        /// <summary>
        /// Email address of the user.
        /// </summary>
        [TableColumn(1, typeof(TableTextElement))]
        [DetailsField(1, typeof(DetailsFieldTextElement))]
        public string Email { get; set; }

        /// <summary>
        /// Name of the user.
        /// </summary>
        [TableColumn(2, typeof(TableTextElement))]
        [DetailsField(2, typeof(DetailsFieldTextElement))]
        public string Name { get; set; }

        /// <summary>
        /// Registration date of the user.
        /// </summary>
        [TableColumn(3, "Registration", typeof(TableDateTimeElement))]
        [DetailsField(3, "Registration", typeof(DetailsFieldDateTimeElement))]
        public DateTimeOffset RegistrationDate { get; set; }

        /// <summary>
        /// Flag that indicates whether the user is activate his/her two factor authentication.
        /// </summary>
        [TableColumn(4, "2FA", typeof(TableFlagElement))]
        [DetailsField(4, typeof(DetailsFieldFlagElement))]
        public bool TwoFactorEnabled { get; set; }

        /// <summary>
        /// Flag that indicates whether the user is locked out.
        /// </summary>
        [TableColumn(5, "Locked Out", typeof(TableFlagElement))]
        [DetailsField(5, "Locked Out", typeof(DetailsFieldFlagElement))]
        public bool IsLockedOut { get; set; }

        /// <summary>
        /// Flat that indicates whether the user has been confirmed his email address.
        /// </summary>
        [TableColumn(6, "Email Confirmed", typeof(TableFlagElement))]
        [DetailsField(6, "Email Confirmed", typeof(DetailsFieldFlagElement))]
        public bool EmailConfirmed { get; set; }
    }
}
