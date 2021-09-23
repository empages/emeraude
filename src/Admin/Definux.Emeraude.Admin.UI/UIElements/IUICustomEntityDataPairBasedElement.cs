namespace Definux.Emeraude.Admin.UI.UIElements
{
    /// <summary>
    /// Contract for elements that are based on <see cref="ICustomEntityDataPair"/>.
    /// </summary>
    public interface IUICustomEntityDataPairBasedElement
    {
        /// <summary>
        /// Returns the instance of current custom entity data pair.
        /// </summary>
        /// <returns></returns>
        ICustomEntityDataPair GetSource();
    }
}