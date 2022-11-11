using System.Threading.Tasks;

namespace EmPages.Pages;

/// <summary>
/// Base contract for page command.
/// </summary>
public interface IEmPageCommand
{
    /// <summary>
    /// Handles the command.
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    Task<EmPageCommandResult> HandleAsync(EmPageCommandRequest request);
}