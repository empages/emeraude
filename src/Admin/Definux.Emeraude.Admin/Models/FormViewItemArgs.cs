using System.Reflection;
using Definux.Emeraude.Admin.Attributes;

namespace Definux.Emeraude.Admin.Models
{
    /// <summary>
    /// Form view item args of <see cref="IEntityAdminSchemaModel"/>.
    /// </summary>
    public class FormViewItemArgs : ViewItemArgs<FormInputAttribute>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormViewItemArgs"/> class.
        /// </summary>
        /// <param name="propertyInfo"></param>
        public FormViewItemArgs(PropertyInfo propertyInfo)
            : base(propertyInfo)
        {
        }
    }
}