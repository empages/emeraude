using System;
using System.Collections.Generic;
using System.Text;

namespace Definux.Emeraude.Admin.ClientBuilder.Models
{
    public class ResponseDescription
    {
        public bool Void { get; set; }

        public ClassDescription Class { get; set; }

        public bool IsCollection { get; set; }
    }
}
