namespace Definux.Emeraude.Admin.UI.UIElements.Form.Implementations
{
    /// <summary>
    /// Implementation of <see cref="FormElement"/> that renders an input of type number.
    /// </summary>
    public class FormNumberElement : FormTextElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormNumberElement"/> class.
        /// </summary>
        public FormNumberElement()
            : base()
        {
            this.InputType = "number";
            this.KeepValue = true;
        }
    }
}
