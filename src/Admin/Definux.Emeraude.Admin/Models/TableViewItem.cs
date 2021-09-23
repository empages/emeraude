using System;
using Definux.Utilities.Extensions;

namespace Definux.Emeraude.Admin.Models
{
    /// <summary>
    /// Table view item of <see cref="IEntityAdminSchemaModel"/>.
    /// </summary>
    public class TableViewItem
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TableViewItem"/> class.
        /// </summary>
        /// <param name="args"></param>
        public TableViewItem(TableViewItemArgs args)
        {
            this.Order = args.Attribute.Order;
            this.Name = args.Attribute.Name?.SplitWordsByCapitalLetters() ?? args.Name.SplitWordsByCapitalLetters();
            this.Component = args.Attribute.Component;
            this.Key = args.Name;
            this.Type = args.Type;
        }

        /// <summary>
        /// Order of the column in the table.
        /// </summary>
        public int Order { get; set; }

        /// <summary>
        /// Name of the column that defines the item.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Mapping key of the item.
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// Type of the property of the model.
        /// </summary>
        public Type Type { get; set; }

        /// <summary>
        /// Type of the component that is used for rendering the item.
        /// </summary>
        public Type Component { get; set; }
    }
}