using System;
using System.Collections.Generic;
using System.Text;

namespace Definux.Emeraude.Admin.ClientBuilder.Models
{
    public class ArgumentDescription
    {
        public string Name { get; set; }

        public ClassDescription Class { get; set; }

        public bool IsCollection { get; set; }
    }
}
