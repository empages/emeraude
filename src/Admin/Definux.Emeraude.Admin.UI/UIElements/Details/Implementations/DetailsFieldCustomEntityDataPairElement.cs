namespace Definux.Emeraude.Admin.UI.UIElements.Details.Implementations
{
    /// <summary>
    /// Implementation of <see cref="UIElement"/> for value extracted from custom entity data pair for details elements.
    /// </summary>
    /// <typeparam name="TCustomEntityDataPair">Custom entity data pair type.</typeparam>
    public class DetailsFieldCustomEntityDataPairElement<TCustomEntityDataPair> : UICustomEntityDataPairBasedElement<TCustomEntityDataPair>, IDetailsFieldElement
        where TCustomEntityDataPair : ICustomEntityDataPair
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DetailsFieldCustomEntityDataPairElement{TCustomEntityDataPair}"/> class.
        /// </summary>
        public DetailsFieldCustomEntityDataPairElement()
            : base()
        {
        }

        /// <inheritdoc/>
        public bool HasClipboardCopyButton => true;
    }
}