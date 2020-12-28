using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json.Serialization;

namespace Definux.Emeraude.Admin.ClientBuilder.Models
{
    /// <summary>
    /// Implementaion of API endpoint for the purposes of client builder.
    /// </summary>
    public class Endpoint
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Endpoint"/> class.
        /// </summary>
        public Endpoint()
        {
            this.Arguments = new List<ArgumentDescription>();
        }

        /// <summary>
        /// Identification of the endpoint.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Name of the controller which contains the endpoint.
        /// </summary>
        public string ControllerName { get; set; }

        /// <summary>
        /// Action method name of the endpoint.
        /// </summary>
        public string ActionName { get; set; }

        /// <summary>
        /// Route of the endpoint.
        /// </summary>
        public string Route { get; set; }

        /// <summary>
        /// Is the endpoint requires authentication to be executedd.
        /// </summary>
        public bool Authorized { get; set; }

        /// <summary>
        /// Description if the response of the endpoint.
        /// </summary>
        [JsonIgnore]
        public ResponseDescription Response { get; set; }

        /// <summary>
        /// <see cref="HttpMethod"/> of the endpoint.
        /// </summary>
        [JsonIgnore]
        public HttpMethod Method { get; set; }

        /// <summary>
        /// HTTP method name of the endpoint.
        /// </summary>
        public string MethodName
        {
            get
            {
                return this.Method?.Method;
            }
        }

        /// <summary>
        /// Arguments of the endpoint action.
        /// </summary>
        public List<ArgumentDescription> Arguments { get; set; }

        /// <summary>
        /// The complex argument of the endpoint. The purpose of this property is to get the main request object of the request.
        /// </summary>
        public ArgumentDescription ComplexArgument
        {
            get
            {
                return this.Arguments.FirstOrDefault(x => x.Type.IsComplex);
            }
        }

        /// <summary>
        /// Arguments names of the endpoint, separated with comma and join into a string.
        /// </summary>
        public string ArgumentsListString
        {
            get
            {
                if (this.Arguments == null || this.Arguments.Count == 0)
                {
                    return string.Empty;
                }

                return string.Join(", ", this.Arguments.Select(x => x.Name));
            }
        }

        /// <summary>
        /// Arguments names of the endpoint, separated with comma and join into a string with their types.
        /// </summary>
        public string StrongTypedArgumentsListString
        {
            get
            {
                if (this.Arguments == null || this.Arguments.Count == 0)
                {
                    return string.Empty;
                }

                return string.Join(", ", this.Arguments.Select(x => $"{x.Type.Name} {x.Name}"));
            }
        }
    }
}
