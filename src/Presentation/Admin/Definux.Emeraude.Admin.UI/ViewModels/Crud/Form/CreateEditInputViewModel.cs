using Definux.Emeraude.Admin.UI.UIElements.Form;
using Microsoft.AspNetCore.Html;
using System;

namespace Definux.Emeraude.Admin.UI.ViewModels.Crud.Form
{
    public class CreateEditInputViewModel
    {
        public string Label { get; set; }

        public string Name { get; set; }

        public object Value { get; set; }

        public Type DataSourceType { get; set; }

        public string VisualizationPropertyName { get; set; }

        public int Order { get; set; }

        public bool IsFlag 
        { 
            get
            {
                return DataSourceType == typeof(bool);
            }
        }

        public IFormElement FormElement { get; set; }

        public IHtmlContent RenderHtmlContent()
        {
            FormElement.TargetProperty = Name;
            FormElement.Label = Label;
            FormElement.Value = Value;
            FormElement.VisibleKey = VisualizationPropertyName;
            FormElement.DataSource = DataSourceType;
            return FormElement.RenderHtmlString();
        }
    }
}
