using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Emeraude.Pages.Views;

namespace Emeraude.Pages.Services;

/// <inheritdoc />
internal class PageMapper : IEmPageMapper
{
    private readonly IEnumerable<IEmMappingStrategy> mappingStrategies;
    private readonly IDictionary<Type, Type> viewItemToStrategyMap;

    /// <summary>
    /// Initializes a new instance of the <see cref="PageMapper"/> class.
    /// </summary>
    /// <param name="mappingStrategies"></param>
    public PageMapper(IEnumerable<IEmMappingStrategy> mappingStrategies)
    {
        this.mappingStrategies = mappingStrategies;
        this.viewItemToStrategyMap = new Dictionary<Type, Type>
        {
            { typeof(EmTableViewItem), typeof(TableMappingStrategy) },
            { typeof(EmDetailsViewItem), typeof(DetailsMappingStrategy) },
            { typeof(EmFormViewItem), typeof(FormMappingStrategy) },
        };
    }

    /// <inheritdoc/>
    public async Task<IEmResponseModel> MapAsync(IEmPage page, EmPageRequest request) =>
        await this.GetPageConversionStrategy(page).MapAsync(page, request);

    private IEmMappingStrategy GetPageConversionStrategy(IEmPage page)
    {
        var viewContext = page.GetViewContext();
        var viewItemType = viewContext.ViewItemType;
        var targetStrategyType = this.viewItemToStrategyMap[viewItemType];
        return this.mappingStrategies.FirstOrDefault(x => x.GetType() == targetStrategyType);
    }
}