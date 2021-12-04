using System.Collections.Generic;
using System.Threading.Tasks;
using Emeraude.Application.Admin.EmPages.Models.FormView;

namespace Emeraude.Application.Admin.EmPages.Schema.FormView;

/// <summary>
/// Contract for selectable custom data source. The idea of that type is to define a map between a custom data and some ID that can be used a selected key.
/// It can be used for data extracted from the database (data and its Id) or any other custom data that is applicable for your case.
/// Take into account that selectable custom data source will be registered as a scoped dependency.
/// </summary>
public interface IFormViewSelectableCustomDataSource
{
    /// <summary>
    /// A preparation method for the source. The execution of that method will be immediately after the instantiation of the implementation class.
    /// Use this method to store the source data into the memory.
    /// </summary>
    /// <returns></returns>
    Task PrepareDataAsync();

    /// <summary>
    /// Gets selectable custom data items for the specified view model.
    /// </summary>
    /// <param name="viewModel"></param>
    /// <returns></returns>
    Task<IEnumerable<FormViewSelectableCustomDataItem>> GetItemsAsync(EmPageFormViewModel viewModel);
}