using Definux.Emeraude.Application.Admin.EmPages.Shared;

namespace Definux.Emeraude.Application.Admin.EmPages.Components.Mutators
{
    /// <summary>
    /// Component that mutate domain entity reference.
    /// </summary>
    public class EmPageEntityMutator : EmPageComponent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmPageEntityMutator"/> class.
        /// </summary>
        public EmPageEntityMutator()
            : base(EmPageComponentType.Mutator)
        {
        }
    }
}