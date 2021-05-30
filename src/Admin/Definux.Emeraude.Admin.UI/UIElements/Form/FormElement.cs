using System;

namespace Definux.Emeraude.Admin.UI.UIElements.Form
{
    /// <inheritdoc cref="IFormElement"/>
    public abstract class FormElement : UIElement, IFormElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormElement"/> class.
        /// </summary>
        public FormElement()
            : base()
        {
        }

        /// <inheritdoc/>
        public string Label { get; set; }

        /// <inheritdoc/>
        public string TargetProperty { get; set; }

        /// <inheritdoc/>
        public string VisibleKey { get; set; }

        /// <inheritdoc/>
        public object Value { get; set; }

        /// <inheritdoc/>
        public bool Hidden { get; set; }

        /// <inheritdoc/>
        public bool IsNullable
        {
            get
            {
                if (this.Value == null)
                {
                    return true;
                }
                else
                {
                    return Nullable.GetUnderlyingType(this.Value.GetType()) != null;
                }
            }
        }
    }
}
