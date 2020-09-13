using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json.Serialization;

namespace Definux.Emeraude.Admin.ClientBuilder.Models
{
    public class Endpoint
    {
        public Endpoint()
        {
            Arguments = new List<ArgumentDescription>();
        }

        public string Id { get; set; }

        public string ControllerName { get; set; }

        public string ActionName { get; set; }

        public string Route { get; set; }

        public bool Authorized { get; set; }

        [JsonIgnore]
        public ResponseDescription Response { get; set; }

        [JsonIgnore]
        public HttpMethod Method { get; set; }

        public string MethodName
        {
            get
            {
                return Method?.Method;
            }
        }

        public List<ArgumentDescription> Arguments { get; set; }

        public ArgumentDescription ComplexArgument 
        { 
            get
            {
                return Arguments.FirstOrDefault(x => x.Class.IsComplex);
            }
        }

        public string ArgumentsListString 
        { 
            get
            {
                if (Arguments == null || Arguments.Count == 0)
                {
                    return string.Empty;
                }

                return string.Join(", ", Arguments.Select(x => x.Name));
            }
        }

        public string StrongTypedArgumentsListString
        {
            get
            {
                if (Arguments == null || Arguments.Count == 0)
                {
                    return string.Empty;
                }

                return string.Join(", ", Arguments.Select(x => $"{x.Class.Name} {x.Name}"));
            }
        }
    }
}
