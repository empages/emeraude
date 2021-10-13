using System;

namespace Definux.Emeraude.ClientBuilder.Attributes
{
    /// <summary>
    /// Decorates action from API controller to be marked as a endpoint with specified response type.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
    public class EndpointAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EndpointAttribute"/> class.
        /// </summary>
        /// <param name="responseType"></param>
        public EndpointAttribute(Type responseType)
        {
            this.ResponseType = responseType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EndpointAttribute"/> class.
        /// </summary>
        public EndpointAttribute()
        {
        }

        /// <summary>
        /// Result type of the endpoint.
        /// </summary>
        public Type ResponseType { get; private set; }
    }
}
