using Definux.Emeraude.Admin.EmPages.Schema;

namespace Definux.Emeraude.Admin.EmPages.Data.Requests
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