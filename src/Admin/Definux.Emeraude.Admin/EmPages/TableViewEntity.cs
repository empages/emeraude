using System.Collections.Generic;
using System.Linq;
using Definux.Emeraude.Admin.Models;

namespace Definux.Emeraude.Admin.EmPages
{
    /// <summary>
    /// Definition for entity in table view format.
    /// </summary>
    public class TableViewEntity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TableViewEntity"/> class.
        /// </summary>
        /// <param name="model"></param>
        public TableViewEntity(IEmPageModel model)
        {
            this.Fields = model
                .GetType()
                .GetProperties()
                .Select(x => new TableViewEntityField
                {
                    Property = x.Name,
                    Value = x.GetValue(model),
                });
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TableViewEntity"/> class.
        /// </summary>
        public TableViewEntity()
        {
        }

        /// <summary>
        /// Collection of all fields of the current entity.
        /// </summary>
        public IEnumerable<TableViewEntityField> Fields { get; set; }
    }
}