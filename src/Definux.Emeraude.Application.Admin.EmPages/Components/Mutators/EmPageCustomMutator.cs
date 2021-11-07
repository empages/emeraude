using System.Collections.Generic;
using Definux.Emeraude.Application.Admin.EmPages.Shared;

namespace Definux.Emeraude.Application.Admin.EmPages.Components.Mutators
{
    /// <summary>
    /// Component that mutate values from custom collections.
    /// </summary>
    public class EmPageCustomMutator : EmPageComponent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmPageCustomMutator"/> class.
        /// </summary>
        public EmPageCustomMutator()
            : base(EmPageComponentType.Mutator)
        {
        }

        /// <summary>
        /// Collection of all possible options from this component.
        /// </summary>
        public IEnumerable<string> Options { get; set; }
    }
}