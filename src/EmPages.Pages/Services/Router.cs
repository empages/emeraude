namespace EmPages.Pages.Services;

/// <inheritdoc />
internal class Router : IEmRouter
{
    private readonly IEmPageStore schemaStore;

    /// <summary>
    /// Initializes a new instance of the <see cref="Router"/> class.
    /// </summary>
    /// <param name="schemaStore"></param>
    public Router(IEmPageStore schemaStore)
    {
        this.schemaStore = schemaStore;
    }

    /// <inheritdoc/>
    public EmPageDescriptor RouteToPage(string route)
    {
        throw new System.NotImplementedException();
    }
}