using System.Reflection;
using Definux.Emeraude.Admin.Attributes;

namespace Definux.Emeraude.Admin.Models
{
    /// <summary>
    /// Table view item args of <see cref="IEntityAdminSchemaModel"/>.
    /// </summary>
    public class TableViewItemArgs : ViewItemArgs<TableColumnAttribute>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TableViewItemArgs"/> class.
        /// </summary>
        /// <param name="propertyInfo"></param>
        public TableViewItemArgs(PropertyInfo propertyInfo)
            : base(propertyInfo)
        {
        }
    }
}