using System;
using System.Reflection;
using Definux.Utilities.Extensions;

namespace Definux.Emeraude.Admin.Models
{
    /// <summary>
    /// Abstract class that defines the view item args of <see cref="IEntityAdminSchemaModel"/>.
    /// </summary>
    /// <typeparam name="TAttribute">Attribute used for selecting property from the model.</typeparam>
    public abstract class ViewItemArgs<TAttribute>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ViewItemArgs{TAttribute}"/> class.
        /// </summary>
        /// <param name="propertyInfo"></param>
        public ViewItemArgs(PropertyInfo propertyInfo)
        {
            this.Name = propertyInfo.Name;
            this.Type = propertyInfo.PropertyType;
            this.Attribute = propertyInfo.GetAttribute<TAttribute>();
        }

        /// <summary>
        /// Name of the property that defines the item.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Type of the property that defines the item.
        /// </summary>
        public Type Type { get; set; }

        /// <summary>
        /// Decoration attribute of the property that defines the item.
        /// </summary>
        public TAttribute Attribute { get; set; }
    }
}