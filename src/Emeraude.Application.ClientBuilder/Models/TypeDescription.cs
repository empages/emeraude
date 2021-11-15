using System.Collections.Generic;
using System.Linq;
using Definux.Utilities.Extensions;

namespace Emeraude.Application.ClientBuilder.Models
{
    /// <summary>
    /// Simplified assembly type description.
    /// </summary>
    public class TypeDescription
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TypeDescription"/> class.
        /// </summary>
        public TypeDescription()
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
        /// Full name of the class with the generic suffix.
        /// </summary>
        public string FullNameWithGeneric => this.FullName + this.GenericTypeSuffix;

        /// <summary>
        /// JavaScript name of the class.
        /// </summary>
        public string JavaScriptTypeName { get; set; }

        /// <summary>
        /// List of all properties of the class.
        /// </summary>
        public List<PropertyDescription> Properties { get; set; }

        /// <summary>
        /// Indicates that the type is collection or not.
        /// </summary>
        public bool IsCollection { get; set; }

        /// <summary>
        /// Indicates that the type is nullable or not.
        /// </summary>
        public bool IsNullable { get; set; }

        /// <summary>
        /// Indicates that the type is enumeration or not.
        /// </summary>
        public bool IsEnum { get; set; }

        /// <summary>
        /// Indicates that the type is generic type or not.
        /// </summary>
        public bool IsGenericType { get; set; }

        /// <summary>
        /// Generic type description of the type.
        /// </summary>
        public TypeDescription GenericType { get; set; }

        /// <summary>
        /// Generic type description suffix based on the <see cref="GenericType"/>.
        /// </summary>
        public string GenericTypeSuffix => (this.IsGenericType && this.GenericType != null) ? $"Of{this.GenericType?.Name}" : string.Empty;

        /// <summary>
        /// Indicates that the type is primitive type (false) or not (true).
        /// </summary>
        public bool IsComplex { get; set; }

        /// <summary>
        /// Enumeration values in case when type is enum.
        /// </summary>
        public Dictionary<string, int> EnumValues { get; set; }

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
