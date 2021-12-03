namespace Emeraude.Application.Admin.EmPages.Models
{
    /// <summary>
    /// Simplified EmPage model.
    /// </summary>
    public class EmPageSimpleModel
    {
        /// <summary>
        /// Route of the EmPage.
        /// </summary>
        public string Route { get; set; }

        /// <summary>
        /// Title of the EmPage.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Description of the EmPage.
        /// </summary>
        public string Description { get; set; }
    }
}