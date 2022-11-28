using System.Collections.Generic;
using System.Linq;
using Essentials.Extensions;

namespace EmPages.Pages.Services;

/// <inheritdoc />
public class EmLayoutService : IEmLayoutService
{
    private readonly IEmPageStore pageStore;

    /// <summary>
    /// Initializes a new instance of the <see cref="EmLayoutService"/> class.
    /// </summary>
    /// <param name="pageStore"></param>
    public EmLayoutService(IEmPageStore pageStore)
    {
        this.pageStore = pageStore;
    }

    /// <inheritdoc/>
    public EmLayout GetLayout() =>
        new EmLayout
        {
            NavigationItems = this.FetchNavigationItems(),
        };

    private IEnumerable<EmNavigationItem> FetchNavigationItems() =>
        this.pageStore
            .PageDescriptors
            .Where(x => x.PageType.HasAttribute<EmNavigationItemAttribute>())
            .Select(x =>
            {
                var layoutItemAttribute = x.PageType.GetAttribute<EmNavigationItemAttribute>();
                return new EmNavigationItem
                {
                    Title = layoutItemAttribute.Title,
                    Icon = layoutItemAttribute.Icon,
                    Order = layoutItemAttribute.Order,
                    Route = x.PageRoute.Template,
                };
            })
            .OrderBy(x => x.Order)
            .ToList();
}