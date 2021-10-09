using Definux.Emeraude.Admin.EmPages.Schema;
using Definux.Emeraude.Domain.Entities;
using MediatR;

namespace Definux.Emeraude.Admin.EmPages.Data.Requests.EmPageDataRawModel
{
    /// <summary>
    /// Interface that wraps raw model request handler.
    /// </summary>
    /// <typeparam name="TRawModelQuery">Raw model query.</typeparam>
    /// <typeparam name="TEntity">Target entity.</typeparam>
    /// <typeparam name="TModel">EmPage model.</typeparam>
    public interface IEmPageDataRawModelQueryHandler<in TRawModelQuery, TEntity, TModel> : IRequestHandler<TRawModelQuery, TModel>
        where TEntity : class, IEntity, new()
        where TModel : class, IEmPageModel, new()
        where TRawModelQuery : IEmPageDataRawModelQuery<TEntity, TModel>
    {
    }
}