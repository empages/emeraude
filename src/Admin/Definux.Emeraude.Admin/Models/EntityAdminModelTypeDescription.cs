using System;
using System.Collections.Generic;

namespace Definux.Emeraude.Admin.Models
{
    /// <summary>
    /// Description of entity admin model type.
    /// </summary>
    public class EntityAdminModelTypeDescription
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EntityAdminModelTypeDescription"/> class.
        /// </summary>
        /// <param name="type"></param>
        public EntityAdminModelTypeDescription(Type type)
        {
            this.TableViewItems = new List<TableViewItem>();
            this.DetailsViewItems = new List<DetailsViewItem>();
            this.FormViewItems = new List<FormViewItem>();

            this.Type = type;
            this.SchemaSettings = BuildSchemaSettings(type);
        }

        /// <summary>
        /// Type of the model.
        /// </summary>
        public Type Type { get; set; }

        /// <summary>
        /// Table view items of the model.
        /// </summary>
        public IEnumerable<TableViewItem> TableViewItems { get; set; }

        /// <summary>
        /// Details view items of the model.
        /// </summary>
        public IEnumerable<DetailsViewItem> DetailsViewItems { get; set; }

        /// <summary>
        /// Form view items of the model.
        /// </summary>
        public IEnumerable<FormViewItem> FormViewItems { get; set; }

        /// <inheritdoc cref="EntityAdminSchemaSettings"/>
        public EntityAdminSchemaSettings SchemaSettings { get; set; }

        private static EntityAdminSchemaSettings BuildSchemaSettings(Type type)
        {
            var schemaInstance = Activator.CreateInstance(type) as IEntityAdminSchemaModel;
            if (schemaInstance == null)
            {
                throw new ArgumentException($"Type {type.FullName} is not a valid schema.");
            }

            var settings = schemaInstance.Setup();
            if (settings == null)
            {
                throw new ArgumentException($"Schema settings of type {type.FullName} must be setup.");
            }

            if (string.IsNullOrWhiteSpace(settings.Key))
            {
                throw new ArgumentException($"Entity key of type {type.FullName} cannot be empty.");
            }

            return settings;
        }
    }
}