using System;

namespace Definux.Emeraude.Admin.ClientBuilder.DataAnnotations
{
    /// <summary>
    /// Decorates action from API controller for Definux automatic store generation.
    /// </summary>
    public class EndpointAttribute : Attribute
    {
        public EndpointAttribute(Type responseType)
        {
            ResponseType = responseType;
        }

        public EndpointAttribute()
        {

        }

        public Type ResponseType { get; private set; }
    }
}
