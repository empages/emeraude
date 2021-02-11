namespace Definux.Emeraude.Admin.Models
{
    /// <summary>
    /// Entity select model used for selectable data extraction from API requests.
    /// </summary>
    public class EntitySelectModel
    {
        /// <summary>
        /// Identifier of data item.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Text visualization of data item.
        /// </summary>
        public string Text { get; set; }
    }
}