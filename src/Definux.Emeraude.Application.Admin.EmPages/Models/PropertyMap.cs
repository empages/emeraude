namespace Definux.Emeraude.Application.Admin.EmPages.Models
{
    /// <summary>
    /// Wrapper of dictionary that contains mapped value for specific property.
    /// </summary>
    /// <typeparam name="TValue">Type of the mapped value.</typeparam>
    public class PropertyMap<TValue>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyMap{TValue}"/> class.
        /// </summary>
        /// <param name="property"></param>
        /// <param name="value"></param>
        public PropertyMap(string property, TValue value)
        {
            this.Property = property;
            this.Value = value;
        }

        /// <summary>
        /// Name of the property.
        /// </summary>
        public string Property { get; set; }

        /// <summary>
        /// Mapped value of the property.
        /// </summary>
        public TValue Value { get; set; }
    }
}