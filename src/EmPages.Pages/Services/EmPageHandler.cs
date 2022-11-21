using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmPages.Pages.Views;

namespace EmPages.Pages.Services;

/// <inheritdoc />
internal class EmPageHandler : IEmPageHandler
{
    private readonly IEnumerable<IEmMappingStrategy> mappingStrategies;
    private readonly IDictionary<Type, Type> viewItemToStrategyMap;

    /// <summary>
    /// Initializes a new instance of the <see cref="EmPageHandler"/> class.
    /// </summary>
    /// <param name="mappingStrategies"></param>
    public EmPageHandler(IEnumerable<IEmMappingStrategy> mappingStrategies)
    {
        this.mappingStrategies = mappingStrategies;
        this.viewItemToStrategyMap = new Dictionary<Type, Type>
        {
            { typeof(EmTableViewItem), typeof(EmTableMappingStrategy) },
            { typeof(EmDetailsViewItem), typeof(EmDetailsMappingStrategy) },
            { typeof(EmFormViewItem), typeof(EmFormMappingStrategy) },
        };
    }

    /// <inheritdoc/>
    public async Task<IEmResponseModel> HandleAsync(IEmPage page, EmPageRequest request) =>
        await this.GetPageConversionStrategy(page).MapAsync(page, request);

    private IEmMappingStrategy GetPageConversionStrategy(IEmPage page)
    {
        var viewContext = page.GetViewContext();
        var viewItemType = viewContext.ViewItemType;
        var targetStrategyType = this.viewItemToStrategyMap[viewItemType];
        return this.mappingStrategies.FirstOrDefault(x => x.GetType() == targetStrategyType);
    }
}