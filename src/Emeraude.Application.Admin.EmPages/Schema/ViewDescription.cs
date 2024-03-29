﻿using System.Collections.Generic;
using System.Linq;

namespace Emeraude.Application.Admin.EmPages.Schema;

/// <summary>
/// Abstract implementation of view description.
/// </summary>
/// <typeparam name="TViewItem">View item type.</typeparam>
public abstract class ViewDescription<TViewItem>
    where TViewItem : class, IViewItem
{
    /// <summary>
    /// View items of the view.
    /// </summary>
    public IEnumerable<TViewItem> ViewItems { get; set; }

    /// <summary>
    /// Page actions of the current view.
    /// </summary>
    public IList<EmPageAction> PageActions { get; set; }

    /// <summary>
    /// Indicates whether the current view is active or not.
    /// </summary>
    public virtual bool IsActive => this.ViewItems != null && this.ViewItems.Any();
}