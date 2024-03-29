﻿using System;
using System.Reflection;
using System.Threading.Tasks;
using Emeraude.Application.Admin.EmPages.Data.Requests.EmPageDataFetch;
using Emeraude.Application.Admin.EmPages.Schema;
using Emeraude.Application.Admin.EmPages.Utilities;

namespace Emeraude.Application.Admin.EmPages.Data;

/// <summary>
/// Data manager that provides access to all data requests of EmPages.
/// </summary>
public interface IEmPageDataManager
{
    /// <summary>
    /// Get instance of EmPage model.
    /// </summary>
    /// <param name="modelId"></param>
    /// <returns></returns>
    Task<IEmPageModel> GetRawModelAsync(string modelId);

    /// <summary>
    /// Get instance of EmPage model.
    /// </summary>
    /// <param name="filter"></param>
    /// <returns></returns>
    Task<IEmPageModel> GetRawModelAsync(EmPageDataFilter filter);

    /// <summary>
    /// Fetch operation.
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    Task<TableViewDataRequestResult> FetchAsync(EmPageDataFetchQueryBody request);

    /// <summary>
    /// Details operation.
    /// </summary>
    /// <param name="modelId"></param>
    /// <returns></returns>
    Task<EmPageModelResponse> DetailsAsync(string modelId);

    /// <summary>
    /// Create operation.
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    Task<string> CreateAsync(IEmPageModel model);

    /// <summary>
    /// Edit operation.
    /// </summary>
    /// <param name="modelId"></param>
    /// <param name="model"></param>
    /// <returns></returns>
    Task<string> EditAsync(string modelId, IEmPageModel model);

    /// <summary>
    /// Delete operation.
    /// </summary>
    /// <param name="modelId"></param>
    /// <returns></returns>
    Task<bool> DeleteAsync(string modelId);
}