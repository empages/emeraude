namespace Definux.Emeraude.Application.Admin.EmPages.Models
{
    /// <summary>
    /// Wrapper of parameter name - value pair.
    /// </summary>
    public class Parameter
    {
        /// <summary>
        /// Name of the parameter.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Value of the parameter.
        /// </summary>
        public object Value { get; set; }
    }
}