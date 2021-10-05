namespace Definux.Emeraude.Admin.EmPages.Data
{
    /// <summary>
    /// Implementation that contains data and meta of property of the entity.
    /// </summary>
    public class EmPageModelResponseField
    {
        /// <summary>
        /// Property of the entity.
        /// </summary>
        public string Property { get; set; }

        /// <summary>
        /// Value of the entity for current property.
        /// </summary>
        public object Value { get; set; }
    }
}