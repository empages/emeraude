using System;

namespace Definux.Emeraude.Admin.UI.UIElements.Form
{
    public abstract class FormElement : UIElement, IFormElement
    {
        public FormElement()
            : base()
        {

        }

        public string Label { get; set; }

        public string TargetProperty { get; set; }

        public string VisibleKey { get; set; }

        public object Value { get; set; }

        public bool Hidden { get; set; }

        public bool IsNullable
        {
            get
            {
                if (Value == null)
                {
                    return true;
                }
                else
                {
                    return Nullable.GetUnderlyingType(Value.GetType()) != null;
                }
            }
        }
    }
}
