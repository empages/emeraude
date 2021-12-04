using System;
using Emeraude.Application.Consumer.Adapters;
using Emeraude.Configuration.Options;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Emeraude.Application.Consumer;

/// <summary>
/// Options for consumer part of Emeraude.
/// </summary>
public class EmConsumerOptions : IEmOptions
{
    /// <summary>
    /// Implementation type of <see cref="ISitemapComposition"/>.
    /// </summary>
    public Type SitemapCompositionType { get; private set; }

    /// <summary>
    /// Set sitemap composition type.
    /// </summary>
    /// <typeparam name="TSitemapComposition">Sitemap composition implementation type.</typeparam>
    public void SetSitemapComposition<TSitemapComposition>()
        where TSitemapComposition : class, ISitemapComposition
    {
        this.SitemapCompositionType = typeof(TSitemapComposition);
    }

    /// <summary>
    /// <inheritdoc />
    /// </summary>
    public void Validate()
    {
    }
}