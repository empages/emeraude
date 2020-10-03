using System.Collections.Generic;

namespace Definux.Emeraude.Admin.ClientBuilder.Models
{
    /// <summary>
    /// Simplified assembly type description.
    /// </summary>
    public class TypeDescription
    {
        /// <summary>
        /// Name of the type.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Full name of the type.
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Name of the type in JavaScript format.
        /// </summary>
        public string JavaScriptTypeName { get; set; }

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
        /// Indicates that the type is primitive type (false) or not (true).
        /// </summary>
        public bool IsComplexType
        {
            get
            {
                return this.ComplexType != null;
            }
        }

        /// <summary>
        /// Enumeration values in case when type is enum.
        /// </summary>
        public Dictionary<string, int> EnumValues { get; set; }

        /// <summary>
        /// Description of the type is not primitive.
        /// </summary>
        public ClassDescription ComplexType { get; set; }
    }
}
