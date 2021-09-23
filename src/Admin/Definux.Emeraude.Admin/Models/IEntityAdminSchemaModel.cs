using System.Collections.Generic;
using System.Net.Http;
using Definux.Emeraude.Application.Mapping;

namespace Definux.Emeraude.Admin.Models
{
    /// <summary>
    /// Contract for entity admin schema model used for definition of entity management schema.
    /// </summary>
    public interface IEntityAdminSchemaModel
    {
        /// <summary>
        /// Identifier of the entity.
        /// </summary>
        string Id { get; set; }

        /// <summary>
        /// Configures all features and utilities of the current schema.
        /// </summary>
        /// <returns></returns>
        EntityAdminSchemaSettings Setup();
    }
}