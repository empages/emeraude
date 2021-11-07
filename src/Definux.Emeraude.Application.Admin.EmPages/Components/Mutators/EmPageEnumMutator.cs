using Definux.Emeraude.Application.Admin.EmPages.Shared;

namespace Definux.Emeraude.Application.Admin.EmPages.Components.Mutators
{
    /// <summary>
    /// Component that mutate enumerations.
    /// </summary>
    public class EmPageEnumMutator : EmPageComponent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmPageEnumMutator"/> class.
        /// </summary>
        public EmPageEnumMutator()
            : base(EmPageComponentType.Mutator)
        {
        }
    }
}