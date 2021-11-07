using System;

namespace Definux.Emeraude.Application.ClientBuilder.Attributes
{
    /// <summary>
    /// Attribute that indicates that the current action must be tolerated as a endpoint from the API.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class ApiEndpointsControllerAttribute : Attribute
    {
    }
}
