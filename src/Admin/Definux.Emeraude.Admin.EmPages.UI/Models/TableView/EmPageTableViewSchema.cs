using System;
using System.Collections.Generic;
using Definux.Emeraude.Admin.UI.Models;

namespace Definux.Emeraude.Admin.EmPages.UI.Models.TableView
{
    /// <summary>
    /// Schema implementation for table view.
    /// </summary>
    public class EmPageTableViewSchema : EmPageViewSchema
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmPageTableViewSchema"/> class.
        /// </summary>
        /// <param name="context"></param>
        public EmPageTableViewSchema(EmPageViewSchemaContext context)
            : base(context)
        {
            this.HeadModel = new EmPageTableHeadModel();
            this.RowActions = new List<ActionModel>();
        }

        /// <summary>
        /// Head model of the table.
        /// </summary>
        public EmPageTableHeadModel HeadModel { get; }

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