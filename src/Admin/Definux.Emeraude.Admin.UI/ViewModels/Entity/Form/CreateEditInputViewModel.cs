using System;
using Definux.Emeraude.Admin.UI.UIElements.Form;
using Microsoft.AspNetCore.Html;

namespace Definux.Emeraude.Admin.UI.ViewModels.Entity.Form
{
    /// <summary>
    /// Implementation of the create/edit form input.
    /// </summary>
    public class CreateEditInputViewModel
    {
        /// <summary>
        /// Label of the input.
        /// </summary>
        public string Label { get; set; }

        /// <summary>
        /// Name of the input and related POST argument name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Value of the input.
        /// </summary>
        public object Value { get; set; }

        /// <summary>
        /// Flag that indicates that the element must be hidden.
        /// </summary>
        public bool Hidden => this.FormElement?.Hidden ?? false;

        /// <summary>
        /// Data source of the input in case of multiple options for the input.
        /// </summary>
        public Type DataSourceType { get; set; }

        /// <summary>
        /// Visualization property of the data source in case of multiple options for the input.
        /// </summary>
        public string VisualizationPropertyName { get; set; }

        /// <summary>
        /// Order of the input.
        /// </summary>
        public int Order { get; set; }

        /// <summary>
        /// Flag that indicates the input has behavior as a flag.
        /// </summary>
        public bool IsFlag
        {
            get
            {
                return this.DataSourceType == typeof(bool);
            }
        }

        /// <summary>
        /// Render UI element of the input.
        /// </summary>
        public IFormElement FormElement { get; set; }

        /// <summary>
        /// Renders the HTML content for the current input.
        /// </summary>
        /// <returns></returns>
        public IHtmlContent RenderHtmlContent()
        {
            this.FormElement.TargetProperty = this.Name;
            this.FormElement.Label = this.Label;
            this.FormElement.Value = this.Value;
            this.FormElement.VisibleKey = this.VisualizationPropertyName;
            this.FormElement.DataSource = this.DataSourceType;
            return this.FormElement.RenderHtmlString();
        }
    }
}
