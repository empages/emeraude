using System.Collections.Generic;
using System.Linq;
using Definux.Utilities.Extensions;

namespace Definux.Emeraude.Admin.ClientBuilder.Models
{
    /// <summary>
    /// Simplified description of a class assembly type.
    /// </summary>
    public class ClassDescription
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClassDescription"/> class.
        /// </summary>
        public ClassDescription()
        {
            this.Properties = new List<PropertyDescription>();
        }

        /// <summary>
        /// Name of the class.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Full name of the class.
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// JavaScript name of the class.
        /// </summary>
        public string JavaScriptTypeName { get; set; }

        /// <summary>
        /// List of all properties of the class.
        /// </summary>
        public List<PropertyDescription> Properties { get; set; }

        /// <summary>
        /// Indicates that the class has behavior of primitive type (false) or like normal class (true).
        /// </summary>
        public bool IsComplex { get; set; }

        /// <summary>
        /// Constructor arguments names of the class, separated with comma and join into a string.
        /// </summary>
        public string ConstructorArgumentsListString
        {
            get
            {
                if (this.Properties == null || this.Properties.Count == 0)
                {
                    return string.Empty;
                }

                return string.Join(", ", this.Properties.Select(x => x.Name.ToFirstLower()));
            }
        }

        /// <summary>
        /// Constructor arguments names of the endpoint, separated with comma and join into a string with their types.
        /// </summary>
        public string ConstructorStrongTypedArgumentsListString
        {
            get
            {
                if (this.Properties == null || this.Properties.Count == 0)
                {
                    return string.Empty;
                }

                return string.Join(", ", this.Properties.Select(x => $"{x.Type.Name} {x.Name.ToFirstLower()}"));
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return this.Name;
        }
    }
}
