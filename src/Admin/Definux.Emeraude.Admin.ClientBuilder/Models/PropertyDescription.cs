namespace Definux.Emeraude.Admin.ClientBuilder.Models
{
    /// <summary>
    /// Simplified description for a property extracted via reflection.
    /// </summary>
    public class PropertyDescription
    {
        /// <summary>
        /// Name of the property.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Indicates whether the property is read-only or not.
        /// </summary>
        public bool ReadOnly { get; set; }

        /// <summary>
        /// Type description of the property.
        /// </summary>
        public TypeDescription Type { get; set; }

        /// <summary>
        /// Default value for the current type.
        /// </summary>
        public string DefaultValue { get; set; }
    }
}
