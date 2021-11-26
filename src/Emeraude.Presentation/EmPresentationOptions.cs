using System;
using System.Collections.Generic;
using Emeraude.Configuration.Options;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Emeraude.Presentation
{
    /// <summary>
    /// Options for presentation layer of Emeraude.
    /// </summary>
    public class EmPresentationOptions : IEmOptions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmPresentationOptions"/> class.
        /// </summary>
        public EmPresentationOptions()
        {
            this.FeatureProviders = new List<IApplicationFeatureProvider>();
        }

        /// <summary>
        /// Default redirect function that compute the action result redirection after login. If callback is null redirection will be executed to Index of HomeController if exists.
        /// </summary>
        public Func<HttpContext, IActionResult> AuthenticationDefaultRedirectCallback { get; set; }

        /// <summary>
        /// List of additional feature providers for extending the MVC configuration.
        /// </summary>
        public IList<IApplicationFeatureProvider> FeatureProviders { get; }

        /// <inheritdoc/>
        public void Validate()
        {
        }
    }
}