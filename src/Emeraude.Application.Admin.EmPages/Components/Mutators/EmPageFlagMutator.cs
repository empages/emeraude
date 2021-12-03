using Emeraude.Application.Admin.EmPages.Shared;

namespace Emeraude.Application.Admin.EmPages.Components.Mutators
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

        /// <summary>
        /// Text that will be visualized for true option. The default is 'Yes'.
        /// </summary>
        public string TrueText { get; set; } = "Yes";

        /// <summary>
        /// Text that will be visualized for false option. The default is 'No'.
        /// </summary>
        public string FalseText { get; set; } = "No";

        /// <inheritdoc/>
        public override object GetParametersObject() => new
        {
            this.TrueText,
            this.FalseText,
        };
    }
}