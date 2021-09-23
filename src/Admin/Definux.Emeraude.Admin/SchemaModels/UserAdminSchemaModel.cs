using System;
using Definux.Emeraude.Admin.Attributes;
using Definux.Emeraude.Admin.Models;
using Definux.Emeraude.Admin.UI.Components.Base;
using Definux.Emeraude.Application.Mapping;
using Definux.Emeraude.Identity.Entities;

namespace Definux.Emeraude.Admin.SchemaModels
{
    /// <summary>
    /// ViewModel of the user entity.
    /// </summary>
    public class UserAdminSchemaModel : IEntityAdminSchemaModel, IMapFrom<User>
    {
        /// <summary>
        /// Identifier of the user.
        /// </summary>
        [DetailsField(0, typeof(EmText))]
        public string Id { get; set; }

        /// <summary>
        /// Email address of the user.
        /// </summary>
        [TableColumn(1, typeof(EmText))]
        [DetailsField(1, typeof(EmText))]
        public string Email { get; set; }

        /// <summary>
        /// Name of the user.
        /// </summary>
        [TableColumn(2, typeof(EmText))]
        [DetailsField(2, typeof(EmText))]
        public string Name { get; set; }

        /// <summary>
        /// Registration date of the user.
        /// </summary>
        [TableColumn(3, "Registration", typeof(EmText))]
        [DetailsField(3, "Registration", typeof(EmText))]
        public DateTimeOffset RegistrationDate { get; set; }

        /// <summary>
        /// Flag that indicates whether the user is activate his/her two factor authentication.
        /// </summary>
        [TableColumn(4, "2FA", typeof(EmFlag))]
        [DetailsField(4, typeof(EmFlag))]
        public bool TwoFactorEnabled { get; set; }

        /// <summary>
        /// Flag that indicates whether the user is locked out.
        /// </summary>
        [TableColumn(5, "Locked Out", typeof(EmFlag))]
        [DetailsField(5, "Locked Out", typeof(EmFlag))]
        public bool IsLockedOut { get; set; }

        /// <summary>
        /// Flat that indicates whether the user has been confirmed his email address.
        /// </summary>
        [TableColumn(6, typeof(EmFlag))]
        [DetailsField(6, typeof(EmFlag))]
        public bool EmailConfirmed { get; set; }

        /// <inheritdoc/>
        public EntityAdminSchemaSettings Setup()
        {
            return new ()
            {
                Key = "users",
                Title = "Users",
            };
        }
    }
}
