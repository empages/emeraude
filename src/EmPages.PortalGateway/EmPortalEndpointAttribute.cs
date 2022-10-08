using System;

namespace EmPages.PortalGateway;

/// <summary>
/// Attribute that decorates a controller action in order to define an endpoint.
/// </summary>
internal class EmPortalEndpointAttribute : Attribute
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EmPortalEndpointAttribute"/> class.
    /// </summary>
    /// <param name="id"></param>
    public EmPortalEndpointAttribute(string id)
    {
        this.Id = id;
    }

    /// <summary>
    /// Id of the endpoint.
    /// </summary>
    public string Id { get; set; }
}