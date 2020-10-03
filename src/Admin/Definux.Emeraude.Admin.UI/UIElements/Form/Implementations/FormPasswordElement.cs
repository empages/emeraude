namespace Definux.Emeraude.Admin.UI.UIElements.Form.Implementations
{
    /// <summary>
    /// Implementation of <see cref="FormElement"/> that renders an input of type password.
    /// </summary>
    public class FormPasswordElement : FormTextElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormPasswordElement"/> class.
        /// </summary>
        public FormPasswordElement()
            : base()
        {
            this.InputType = "password";
            this.KeepValue = false;
        }
    }
}
