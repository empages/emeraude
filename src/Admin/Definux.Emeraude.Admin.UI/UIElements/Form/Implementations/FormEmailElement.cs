namespace Definux.Emeraude.Admin.UI.UIElements.Form.Implementations
{
    /// <summary>
    /// Implementation of <see cref="FormElement"/> that renders an input of type 'email'.
    /// </summary>
    public class FormEmailElement : FormTextElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormEmailElement"/> class.
        /// </summary>
        public FormEmailElement()
            : base()
        {
            this.InputType = "email";
            this.KeepValue = true;
        }
    }
}
