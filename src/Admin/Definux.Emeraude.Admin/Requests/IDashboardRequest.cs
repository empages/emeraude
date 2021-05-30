using MediatR;

namespace Definux.Emeraude.Admin.Requests
{
    /// <summary>
    /// Dashboard request contract for building dashboard view model.
    /// </summary>
    /// <typeparam name="TResponse">Response type of the request.</typeparam>
    public interface IDashboardRequest<out TResponse> : IRequest<TResponse>
    {
    }
}