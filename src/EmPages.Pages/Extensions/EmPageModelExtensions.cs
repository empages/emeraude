namespace EmPages.Pages.Extensions;

/// <summary>
/// Extensions for <see cref="IEmPageModel"/>.
/// </summary>
public static class EmPageModelExtensions
{
    /// <summary>
    /// Gets EmPage Model property value.
    /// </summary>
    /// <param name="model"></param>
    /// <param name="property"></param>
    /// <returns></returns>
    public static object GetPropertyValue(this IEmPageModel model, string property) =>
        model.GetType().GetProperty(property)?.GetValue(model) ?? default;
}