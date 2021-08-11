namespace Definux.Emeraude.Client.Seo.Models
{
    /// <summary>
    /// Implementation of single HTML meta tag.
    /// </summary>
    public class MetaTag
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MetaTag"/> class.
        /// </summary>
        public MetaTag()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetaTag"/> class.
        /// </summary>
        /// <param name="key"></param>
        public MetaTag(string key)
        {
            this.Key = key;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetaTag"/> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        public MetaTag(string name, string value)
        {
            this.Key = name;
            this.Value = value;
        }

        /// <summary>
        /// Key attribute name of the meta tag. Default value is 'name'.
        /// </summary>
        public string KeyName { get; set; } = "name";

        /// <summary>
        /// Value attribute name of the meta tag. Default value is 'content'.
        /// </summary>
        public string ValueName { get; set; } = "content";

        /// <summary>
        /// Key of the meta tag.
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// Value of the meta tag.
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Flag that returns whether the meta tag has value.
        /// </summary>
        public bool HasValue
        {
            get
            {
                return !string.IsNullOrEmpty(this.Value);
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return this.Value;
        }
    }
}
