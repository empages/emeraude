using Definux.Emeraude.Application.Admin.EmPages.Shared;

namespace Definux.Emeraude.Application.Admin.EmPages.Components.Mutators
{
    /// <summary>
    /// Component that mutate booleans.
    /// </summary>
    public class EmPageFlagMutator : EmPageComponent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmPageFlagMutator"/> class.
        /// </summary>
        public EmPageFlagMutator()
            : base(EmPageComponentType.Mutator)
        {
        }
    }
}