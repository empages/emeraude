using Emeraude.Application.Admin.EmPages.Shared;

namespace Emeraude.Application.Admin.EmPages.Components.Mutators
{
    /// <summary>
    /// Component that mutate dates with times.
    /// </summary>
    public class EmPageDateTimeMutator : EmPageComponent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmPageDateTimeMutator"/> class.
        /// </summary>
        public EmPageDateTimeMutator()
            : base(EmPageComponentType.Mutator)
        {
        }
    }
}