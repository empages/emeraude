using System.Collections.Generic;
using Emeraude.Configuration.Options;
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
        /// List of additional feature providers for extending the MVC configuration.
        /// </summary>
        public IList<IApplicationFeatureProvider> FeatureProviders { get; }

        /// <inheritdoc/>
        public void Validate()
        {
        }
    }
}