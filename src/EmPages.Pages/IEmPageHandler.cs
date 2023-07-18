﻿using System.Threading.Tasks;

namespace EmPages.Pages;

/// <summary>
/// Page mapper is a service that converts business abstraction defined by the model
/// to a page abstraction by using the defined schema.
/// </summary>
public interface IEmPageHandler
{
    /// <summary>
    /// Converts page to response model.
    /// </summary>
    /// <param name="page"></param>
    /// <param name="request"></param>
    /// <returns></returns>
    Task<IEmResponseModel> HandleAsync(IEmPage page, EmPageRequest request);
}