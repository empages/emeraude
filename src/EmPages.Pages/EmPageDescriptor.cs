using System;
using System.Collections.Generic;
using System.Linq;
using EmPages.Pages.Extensions;
using Essentials.Extensions;

namespace EmPages.Pages;

/// <summary>
/// A descriptor for EmPages page.
/// </summary>
public class EmPageDescriptor
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EmPageDescriptor"/> class.
    /// </summary>
    /// <param name="pageType"></param>
    internal EmPageDescriptor(Type pageType)
    {
        try
        {
            this.PageType = pageType;

            var pageInterface = pageType
                .GetInterfaces()
                .First(x => x.GetGenericTypeDefinition() == typeof(IEmPage<,,>));
            this.ModelType = pageInterface?.GetGenericArguments().First();

            this.PageRoute = pageType.ExtractRouteFromPageType();

            var expectedCommandType = typeof(IEmPageCommand);
            this.CommandsTypes = pageType
                .Assembly
                .GetTypes()
                .Where(x => x.Namespace == pageType.Namespace && x.GetInterfaces().Any(xx => xx == expectedCommandType));
        }
        catch (Exception)
        {
            throw new ArgumentException($"Page of type {pageType.FullName} cannot be packed into EmPageSet", nameof(pageType));
        }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="EmPageDescriptor"/> class.
    /// </summary>
    internal EmPageDescriptor()
    {
    }

    /// <summary>
    /// Type of the page.
    /// </summary>
    public Type PageType { get; }

    /// <summary>
    /// Type of the model.
    /// </summary>
    public Type ModelType { get; }

    /// <summary>
    /// Collection of page commands types.
    /// </summary>
    public IEnumerable<Type> CommandsTypes { get; }

    /// <summary>
    /// Route of the page.
    /// </summary>
    public EmPageRoute PageRoute { get; internal set; }

    /// <summary>
    /// Finds a command from the registered for the current page.
    /// </summary>
    /// <param name="command"></param>
    /// <returns></returns>
    public Type FindCommandType(string command) =>
        this.CommandsTypes.FirstOrDefault(x => x.Name == command);
}