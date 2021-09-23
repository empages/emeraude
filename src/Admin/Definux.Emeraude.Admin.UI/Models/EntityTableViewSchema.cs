using System;
using System.Collections.Generic;

namespace Definux.Emeraude.Admin.UI.Models
{
    /// <summary>
    /// Schema implementation for table view.
    /// </summary>
    public class EntityTableViewSchema : EntityViewSchema
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EntityTableViewSchema"/> class.
        /// </summary>
        /// <param name="context"></param>
        public EntityTableViewSchema(EntityViewSchemaContext context)
            : base(context)
        {
            this.HeadModel = new EntityTableHeadModel();
            this.PropertyComponentPair = new Dictionary<string, Type>();
            this.PropertyTypePair = new Dictionary<string, Type>();
            this.RowActions = new List<ActionModel>();
        }

        /// <summary>
        /// Head model of the table.
        /// </summary>
        public EntityTableHeadModel HeadModel { get; }

        /// <summary>
        /// Pair that contains corresponding component for each property of the model.
        /// </summary>
        public IDictionary<string, Type> PropertyComponentPair { get; set; }

        /// <summary>
        /// Pair that contains corresponding type for each property of the model.
        /// </summary>
        public IDictionary<string, Type> PropertyTypePair { get; set; }

        /// <summary>
        /// Indicates that the current table items have actions or not.
        /// </summary>
        public bool HasActions { get; set; }

        /// <summary>
        /// Collection of all actions that will be applied to each entity.
        /// </summary>
        public IList<ActionModel> RowActions { get; set; }
    }
}