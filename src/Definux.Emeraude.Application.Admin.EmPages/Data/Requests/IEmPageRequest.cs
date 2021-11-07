using Definux.Emeraude.Application.Admin.EmPages.Schema;

namespace Definux.Emeraude.Application.Admin.EmPages.Data.Requests
{
    /// <summary>
    /// Main contract for EmPage data command or query.
    /// </summary>
    /// <typeparam name="TModel">EmPage model.</typeparam>
    public interface IEmPageRequest<TModel>
        where TModel : class, IEmPageModel, new()
    {
    }
}