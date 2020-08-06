using System;

namespace Definux.Emeraude.Admin.Attributes
{
    public class FormInputAttribute : Attribute
    {
        public FormInputAttribute(
            int order, 
            string name, 
            Type uiElementType, 
            Type dataSourceType = null,
            string visualizationPropertyName = null)
        {
            Order = order;
            Name = name;
            UIElementType = uiElementType;
            DataSourceType = dataSourceType;
            VisualizationPropertyName = visualizationPropertyName;
        }

        public int Order { get; }

        public string Name { get; }

        /// <summary>
        /// UI element type which inherit Definux.Emeraude.Admin.UI.UIElements.Form.IFormElement
        /// </summary>
        public Type UIElementType { get; }

        public Type DataSourceType { get; set; }

        public string VisualizationPropertyName { get; set; }
    }
}
