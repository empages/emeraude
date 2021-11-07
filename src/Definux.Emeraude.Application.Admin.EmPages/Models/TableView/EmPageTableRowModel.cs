using System.Collections.Generic;
using Definux.Emeraude.Admin.UI.Models;

namespace Definux.Emeraude.Application.Admin.EmPages.Models.TableView
{
    /// <summary>
    /// Implementation model of table row.
    /// </summary>
    public class EmPageTableRowModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmPageTableRowModel"/> class.
        /// </summary>
        public EmPageTableRowModel()
        {
            this.Cells = new List<EmPageTableCellModel>();
            this.Actions = new List<ActionModel>();
        }

        /// <summary>
        /// Row identifier.
        /// </summary>
        public string Identifier { get; set; }

        /// <summary>
        /// Cells of the current row.
        /// </summary>
        public List<EmPageTableCellModel> Cells { get; }

        /// <summary>
        /// Actions of the current row.
        /// </summary>
        public List<ActionModel> Actions { get; }
    }
}