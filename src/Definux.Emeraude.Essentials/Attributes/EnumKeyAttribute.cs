using System;

namespace Definux.Emeraude.Essentials.Attributes
{
    /// <summary>
    /// Attribute that add additional key information to enumeration.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field)]
    public class EnumKeyAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EnumKeyAttribute"/> class.
        /// </summary>
        /// <param name="key"></param>
        public EnumKeyAttribute(string key)
        {
            this.Key = key;
        }

        /// <summary>
        /// Key of the enumeration.
        /// </summary>
        public string Key { get; }
    }
}