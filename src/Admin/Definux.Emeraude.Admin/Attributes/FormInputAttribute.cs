using System;
using System.Runtime.CompilerServices;
using Definux.Emeraude.Admin.UI.UIElements;
using Definux.Emeraude.Admin.UI.UIElements.Form;
using Definux.Utilities.Functions;

namespace Definux.Emeraude.Admin.Attributes
{
    /// <summary>
    /// Attribute that include the decorated property into the create/edit form of entity admin controller.
    /// </summary>
    public class FormInputAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormInputAttribute"/> class.
        /// </summary>
        /// <param name="order"></param>
        /// <param name="name"></param>
        /// <param name="uiElementType"></param>
        /// <param name="dataSourceType"></param>
        /// <param name="visualizationPropertyName"></param>
        public FormInputAttribute(
            int order,
            string name,
            Type uiElementType,
            Type dataSourceType = null,
            string visualizationPropertyName = null)
        {
            this.Order = order;
            this.Name = name;
            this.UIElementType = uiElementType;
            this.DataSourceType = dataSourceType;
            this.VisualizationPropertyName = visualizationPropertyName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FormInputAttribute"/> class.
        /// </summary>
        /// <param name="order"></param>
        /// <param name="uiElementType"></param>
        /// <param name="dataSourceType"></param>
        /// <param name="visualizationPropertyName"></param>
        /// <param name="propertyName"></param>
        public FormInputAttribute(
            int order,
            Type uiElementType,
            Type dataSourceType = null,
            string visualizationPropertyName = null,
            [CallerMemberName] string propertyName = "")
        {
            this.Order = order;
            this.Name = StringFunctions.SplitWordsByCapitalLetters(propertyName);
            this.UIElementType = uiElementType;
            this.DataSourceType = dataSourceType;
            this.VisualizationPropertyName = visualizationPropertyName;
        }

        /// <summary>
        /// Order of the form input.
        /// </summary>
        public int Order { get; }

        /// <summary>
        /// Name of the label of the form input.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// UI element type that implemented <see cref="IFormElement"/>.
        /// </summary>
        public Type UIElementType { get; }

        /// <summary>
        /// The existence of this property defines external data source for the current property. In case you use database source or additional custom entity data pair <see cref="ICustomEntityDataPair"/>.
        /// </summary>
        public Type DataSourceType { get; set; }

        /// <summary>
        /// Name of the property that will be visualized on the form element.
        /// </summary>
        public string VisualizationPropertyName { get; set; }
    }
}
