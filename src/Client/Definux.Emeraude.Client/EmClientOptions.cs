﻿using System;
using Definux.Emeraude.Client.Adapters;
using Definux.Emeraude.Client.Models;
using Definux.Emeraude.Configuration.Options;

namespace Definux.Emeraude.Client
{
    /// <summary>
    /// Options for client part of Emeraude.
    /// </summary>
    public class EmClientOptions : IEmOptions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmClientOptions"/> class.
        /// </summary>
        public EmClientOptions()
        {
            this.DefaultMetaTags = new MetaTagsModel();
        }

        /// <summary>
        /// Flag that turn on/off the provided client MVC authentication. The default value is true.
        /// </summary>
        public bool HasClientMvcAuthentication { get; set; } = true;

        /// <summary>
        /// Flag that turn on/off the provided client API authentication. The default value is true.
        /// </summary>
        public bool HasClientApiAuthentication { get; set; } = true;

        /// <summary>
        /// Implementation type of <see cref="ISitemapComposition"/>.
        /// </summary>
        public Type SitemapCompositionType { get; private set; }

        /// <summary>
        /// Default meta tags model.
        /// </summary>
        public MetaTagsModel DefaultMetaTags { get; set; }

        /// <summary>
        /// Set sitemap composition type.
        /// </summary>
        /// <typeparam name="TSitemapComposition">Sitemap composition implementation type.</typeparam>
        public void SetSitemapComposition<TSitemapComposition>()
            where TSitemapComposition : class, ISitemapComposition
        {
            this.SitemapCompositionType = typeof(TSitemapComposition);
        }
    }
}