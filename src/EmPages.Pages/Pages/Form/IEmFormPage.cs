namespace EmPages.Pages.Pages.Form;

/// <summary>
/// EmForm page contract.
/// </summary>
public interface IEmFormPage : IEmPage
{
    /// <summary>
    /// Name of the submit command for current page.
    /// </summary>
    string SubmitCommandName { get; }
}