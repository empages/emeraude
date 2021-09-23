using System;
using System.Runtime.CompilerServices;
using Definux.Emeraude.Admin.UI.UIElements.Table;
using Definux.Utilities.Functions;

namespace Definux.Emeraude.Admin.Attributes
{
    /// <summary>
    /// Attribute used for rendering the table of the get all action of admin entity controller.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class TableColumnAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TableColumnAttribute"/> class.
        /// </summary>
        /// <param name="order"></param>
        /// <param name="name"></param>
        /// <param name="component"></param>
        public TableColumnAttribute(int order, string name, Type component)
        {
            this.Order = order;
            this.Name = name;
            this.Component = component;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TableColumnAttribute"/> class.
        /// </summary>
        /// <param name="order"></param>
        /// <param name="component"></param>
        /// <param name="propertyName"></param>
        public TableColumnAttribute(int order, Type component, [CallerMemberName] string propertyName = "")
        {
            this.Order = order;
            this.Name = StringFunctions.SplitWordsByCapitalLetters(propertyName);
            this.Component = component;
        }

        /// <summary>
        /// Order of the column.
        /// </summary>
        public int Order { get; }

        /// <summary>
        /// Name of the column.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Type of the component used for rendering the table cell.
        /// </summary>
        public Type Component { get; }
    }
}