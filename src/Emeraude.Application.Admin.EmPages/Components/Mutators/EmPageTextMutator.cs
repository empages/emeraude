using Emeraude.Application.Admin.EmPages.Shared;

namespace Emeraude.Application.Admin.EmPages.Components.Mutators
{
    /// <summary>
    /// Component that mutate texts.
    /// </summary>
    public class EmPageTextMutator : EmPageComponent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmPageTextMutator"/> class.
        /// </summary>
        public EmPageTextMutator()
            : base(EmPageComponentType.Mutator)
        {
        }

        /// <summary>
        /// Flag that indicates whether the text is large or not.
        /// </summary>
        public bool LargeText { get; set; }
    }
}