using System.Collections.Generic;
using System.Net.Http;

namespace Definux.Emeraude.Admin.Models
{
    /// <summary>
    /// Settings implementation for entity admin schema.
    /// </summary>
    public class EntityAdminSchemaSettings
    {
        /// <summary>
        /// Entity key used for identification of specified entity in plural format. Example: 'dogs'. This key will be used as a route as well.
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// Title of the entity in plural format.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Defines entity actions that can be executed.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<EntityModelAction> ModelActions() =>
            new List<EntityModelAction>
            {
                new ()
                {
                    Order = 0,
                    Name = "Details",
                    Url = "{0}",
                },
                new ()
                {
                    Order = 0,
                    Name = "Modify",
                    Url = "{0}/modify",
                },
                new ()
                {
                    Order = 0,
                    Name = "Delete",
                    Url = "{0}",
                    Method = HttpMethod.Delete,
                    ConfirmationMessage = "Are you sure you want to delete this entity?",
                },
            };
    }
}