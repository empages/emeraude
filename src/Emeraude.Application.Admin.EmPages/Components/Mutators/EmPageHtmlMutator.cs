using Emeraude.Application.Admin.EmPages.Shared;

namespace Emeraude.Application.Admin.EmPages.Components.Mutators
{
    /// <summary>
    /// Component that mutate HTML.
    /// </summary>
    public class EmPageHtmlMutator : EmPageComponent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmPageHtmlMutator"/> class.
        /// </summary>
        public EmPageHtmlMutator()
            : base(EmPageComponentType.Mutator)
        {
        }
    }
}