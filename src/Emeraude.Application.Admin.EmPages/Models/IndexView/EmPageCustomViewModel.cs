using System.Collections.Generic;
using Emeraude.Application.Admin.EmPages.Data;
using Emeraude.Application.Admin.Models;

namespace Emeraude.Application.Admin.EmPages.Models.IndexView;

/// <summary>
/// Model implementation for custom view.
/// </summary>
public class EmPageCustomViewModel
{
    /// <summary>
    /// Name of the component.
    /// </summary>
    public string ComponentName { get; set; }

    /// <summary>
    /// Parameters of the custom view.
    /// </summary>
    public IEnumerable<PropertyMap<object>> Parameters { get; set; }
}