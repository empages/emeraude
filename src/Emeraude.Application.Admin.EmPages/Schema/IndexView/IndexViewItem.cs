using System;
using System.Collections.Generic;

namespace Emeraude.Application.Admin.EmPages.Schema.IndexView;

/// <summary>
/// Index view item of <see cref="IEmPageSchema{TModel}"/>.
/// </summary>
public class IndexViewItem : ViewItem, IValuePipedViewItem
{
    private readonly List<(Type, string[])> valuePipes;

    /// <summary>
    /// Initializes a new instance of the <see cref="IndexViewItem"/> class.
    /// </summary>
    public IndexViewItem()
    {
        this.valuePipes = new List<(Type, string[])>();
    }

    /// <inheritdoc/>
    public IReadOnlyList<(Type, string[])> ValuePipes => this.valuePipes;

    /// <inheritdoc/>
    public void AddValuePipe<TValuePipe>(params string[] parameters)
        where TValuePipe : class, IValuePipe
    {
        this.valuePipes.Add((typeof(TValuePipe), parameters));
    }
}