using System.Reflection;
using Definux.Emeraude.Admin.Attributes;

namespace Definux.Emeraude.Admin.Models
{
    /// <summary>
    /// Details view item args of <see cref="IEntityAdminSchemaModel"/>.
    /// </summary>
    public class DetailsViewItemArgs : ViewItemArgs<DetailsFieldAttribute>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DetailsViewItemArgs"/> class.
        /// </summary>
        /// <param name="propertyInfo"></param>
        public DetailsViewItemArgs(PropertyInfo propertyInfo)
            : base(propertyInfo)
        {
        }
    }
}