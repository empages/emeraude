using System.Collections.Generic;

namespace Definux.Emeraude.Admin.ClientBuilder.Models
{
    public class TypeDescription
    {
        public string Name { get; set; }

        public string FullName { get; set; }

        public string JavaScriptTypeName { get; set; }

        public bool IsCollection { get; set; }

        public bool IsNullable { get; set; }

        public bool IsEnum { get; set; }

        public bool IsComplexType
        {
            get
            {
                return ComplexType != null;
            }
        }

        public Dictionary<string, int> EnumValues { get; set; }

        public ClassDescription ComplexType { get; set; }
    }
}
