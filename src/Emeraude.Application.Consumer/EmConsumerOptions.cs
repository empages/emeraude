using System;
using Emeraude.Application.Consumer.Adapters;
using Emeraude.Configuration.Options;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Emeraude.Application.Consumer
{
    /// <summary>
    /// Options for consumer part of Emeraude.
    /// </summary>
    public class EmConsumerOptions : IEmOptions
    {
        /// <summary>
        /// Default redirect function that compute the action result redirection after login. If callback is null redirection will be executed to Index of HomeController if exists.
        /// </summary>
        public Func<HttpContext, IActionResult> AuthenticationDefaultRedirectCallback { get; set; }

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
}