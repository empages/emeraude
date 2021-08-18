namespace Definux.Emeraude.Admin.UI.UIElements.Table.Implementations
{
    /// <summary>
    /// Implementation of <see cref="UIElement"/> for value extracted from custom entity data pair for table elements.
    /// </summary>
    /// <typeparam name="TCustomEntityDataPair">Custom entity data pair type.</typeparam>
    public class TableCustomEntityDataPairElement<TCustomEntityDataPair> : UICustomEntityDataPairBasedElement<TCustomEntityDataPair>, ITableElement
        where TCustomEntityDataPair : ICustomEntityDataPair
    {
    }
}