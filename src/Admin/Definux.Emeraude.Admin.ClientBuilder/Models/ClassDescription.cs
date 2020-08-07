using Definux.Utilities.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace Definux.Emeraude.Admin.ClientBuilder.Models
{
    public class ClassDescription
    {
        public ClassDescription()
        {
            Properties = new List<PropertyDescription>();
        }

        public string Name { get; set; }

        public string FullName { get; set; }

        public string JavaScriptTypeName { get; set; }

        public List<PropertyDescription> Properties { get; set; }

        public bool IsComplex { get; set; }

        public string ConstructorArgumentsListString
        {
            get
            {
                if (Properties == null || Properties.Count == 0)
                {
                    return string.Empty;
                }

                return string.Join(", ", Properties.Select(x => x.Name.ToFirstLower()));
            }
        }

        public string ConstructorStrongTypedArgumentsListString
        {
            get
            {
                if (Properties == null || Properties.Count == 0)
                {
                    return string.Empty;
                }

                return string.Join(", ", Properties.Select(x => $"{x.Type.Name} {x.Name.ToFirstLower()}"));
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
