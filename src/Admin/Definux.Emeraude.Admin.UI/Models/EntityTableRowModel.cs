using System.Collections.Generic;

namespace Definux.Emeraude.Admin.UI.Models
{
    /// <summary>
    /// Implementation model of table row.
    /// </summary>
    public class EntityTableRowModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EntityTableRowModel"/> class.
        /// </summary>
        public EntityTableRowModel()
        {
            this.Cells = new List<EntityTableCellModel>();
            this.Actions = new List<ActionModel>();
        }

        /// <summary>
        /// Row identifier.
        /// </summary>
        public string Identifier { get; set; }

        /// <summary>
        /// Cells of the current row.
        /// </summary>
        public List<EntityTableCellModel> Cells { get; }

        /// <summary>
        /// Actions of the current row.
        /// </summary>
        public List<ActionModel> Actions { get; }
    }
}