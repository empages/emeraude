namespace Emeraude.Pages.Results;

/// <summary>
/// Form page result.
/// </summary>
/// <typeparam name="TModel">Model type.</typeparam>
public class EmFormPageResult<TModel> : IEmPageResult
    where TModel : class, IEmPageModel, new()
{
    /// <summary>
    /// Data of the result.
    /// </summary>
    public TModel Model { get; set; }
}