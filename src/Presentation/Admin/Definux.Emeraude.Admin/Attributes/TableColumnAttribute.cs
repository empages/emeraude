using System;

namespace Definux.Emeraude.Admin.Attributes
{
    public class TableColumnAttribute : Attribute
    {
        public TableColumnAttribute(int order, string name, Type uiElementType)
        {
            Order = order;
            Name = name;
            UIElementType = uiElementType;
        }

        public int Order { get; }

        public string Name { get; }

        /// <summary>
        /// UI element type which inherit Definux.Emeraude.Admin.UI.UIElements.Table.ITableElement
        /// </summary>
        public Type UIElementType { get; }
    }
}
