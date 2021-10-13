using System;
using Definux.Emeraude.Client.Adapters;
using Definux.Emeraude.Client.Models;
using Definux.Emeraude.Configuration.Options;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Definux.Emeraude.Client
{
    /// <summary>
    /// Options for client part of Emeraude.
    /// </summary>
    public class EmClientOptions : IEmOptions
    {
        /// <summary>
        /// Flag that turn on/off the provided client MVC authentication. The default value is true.
        /// </summary>
        public bool HasClientMvcAuthentication { get; set; } = true;

        /// <summary>
        /// Flag that turn on/off the provided client API authentication. The default value is true.
        /// </summary>
        public bool HasClientApiAuthentication { get; set; } = true;

        /// <summary>
        /// Default redirect function that compute the action result redirection after login. If callback is null redirection will be executed to Index of HomeController if exists.
        /// </summary>
        public Func<HttpContext, IActionResult> ClientAuthenticationDefaultRedirectCallback { get; set; }

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