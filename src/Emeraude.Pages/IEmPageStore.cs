using System.Collections.Generic;
using System.Threading.Tasks;

namespace Emeraude.Pages;

/// <summary>
/// Pages store for initializing and accessing the pages registered into the application.
/// </summary>
public interface IEmPageStore
{
    /// <summary>
    /// Collection of all registered pages.
    /// </summary>
    IReadOnlyCollection<EmPageDescriptor> PageDescriptors { get; }

    /// <summary>
    /// Prepare all schema elements registered into the application - pages, commands, etc.
    /// That method must be invoked on application startup.
    /// </summary>
    /// <returns></returns>
    Task InitializeAsync();
}