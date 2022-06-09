using System.Threading.Tasks;

namespace EmPages.Pages;

/// <summary>
/// Strategy contract for mapping schema to response.
/// </summary>
public interface IEmMappingStrategy
{
    /// <summary>
    /// Converts specified page to response model.
    /// </summary>
    /// <param name="page"></param>
    /// <param name="request"></param>
    /// <returns></returns>
    Task<IEmResponseModel> MapAsync(IEmPage page, EmPageRequest request);
}